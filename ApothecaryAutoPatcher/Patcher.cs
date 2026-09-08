using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;
using ICSharpCode.SharpZipLib;

namespace ApothecaryAutoPatcher;


public class Patcher(
    IPatcherState<ISkyrimMod, ISkyrimModGetter> state
,   Settings                                    settings
)
{
    enum ProcessEffectResult
    {
        NotOverridden,
        Overridden,
        NoEffectData,
        EffectError
    }

    record EffectError(IIngredientGetter Ingredient, Mutagen.Bethesda.Skyrim.Effect Effect, string ErrorMessage)
    {
        public override string ToString()
        {
            return $"Ingredient: {Ingredient.EditorID}, Effect: {Effect.BaseEffect.FormKey}, Error: {ErrorMessage}";
        }
    }

    private          Dictionary<FormKey, List<Effect>>           effectsDictionary = [];
    private readonly IPatcherState<ISkyrimMod, ISkyrimModGetter> state             = state;
    private readonly Settings                                    Settings          = settings;
    private readonly List<EffectError>                           effectErrors      = [];

    private ProcessEffectResult ProcessEffect(
        Mutagen.Bethesda.Skyrim.Effect    effect,
        HashSet<FormKey>                  effectFormKeys
    )
    {
        if (effect.Data == null)                                                          return ProcessEffectResult.NoEffectData;
        if (!effectsDictionary.TryGetValue(effect.BaseEffect.FormKey, out var effectsTo)) return ProcessEffectResult.NotOverridden;

        Effect? effectTo = effectsTo.FirstOrDefault(e => !effectFormKeys.Contains(e.BaseEffect.FormKey));

        if (effectTo is null)
        {
            if (Settings.DuplicateEffectIsStopError)
            {
                return ProcessEffectResult.EffectError;
            }
            else
            {
                Console.WriteLine($"No effect to override for {effect.BaseEffect.FormKey}");
                return ProcessEffectResult.NotOverridden;
            }
        }

        // Add effect even if it's not overriden in order to ensure
        // duplicate effects are not applied to the same ingredient.
        effectFormKeys.Add(effectTo.BaseEffect.FormKey);

        // No overriding if exactly the same.
        if (    effect.BaseEffect.FormKey == effectTo.BaseEffect.FormKey
                && effect.Data.Magnitude     == effectTo.Magnitude
                && effect.Data.Duration      == effectTo.Duration
        )
        {
            return ProcessEffectResult.NotOverridden;
        }

        effect.BaseEffect.FormKey = effectTo.BaseEffect.FormKey;
        effect.Data.Magnitude     = effectTo.Magnitude;
        effect.Data.Duration      = effectTo.Duration;
        return ProcessEffectResult.Overridden;
    }

    private void ProcessIngredient(IIngredientGetter ingredientGetter)
    {
        if (Settings.Blacklist.Contains(ingredientGetter.ToLink())) return;

        var ingredientoverride = ingredientGetter.DeepCopy();
        var overridden         = false;

        HashSet<FormKey> effectFormKeys = [];

        foreach (var effect in ingredientoverride.Effects)
        {
            switch (ProcessEffect(effect, effectFormKeys))
            {
                case ProcessEffectResult.Overridden:
                    overridden = true;
                    break;
                case ProcessEffectResult.NoEffectData:
                    Console.WriteLine($"No effect data for {ingredientGetter.EditorID} effect {effect.BaseEffect.FormKey}");
                    return;
                case ProcessEffectResult.EffectError:
                    effectErrors.Add(new EffectError(ingredientGetter, effect, $"No effect to override for {effect.BaseEffect.FormKey}"));
                    return;
                default:
                    break;
            }
        }

        if (overridden)
        {
            state.PatchMod.Ingredients.Set(ingredientoverride);
        }
    }
    public void Run()
    {
        effectsDictionary = Settings.Effects.ToDictionary(e => e.EffectFrom.FormKey, e => e.EffectsTo);

        foreach (var ingredientGetter in state.LoadOrder.PriorityOrder.Ingredient().WinningOverrides())
        {
            ProcessIngredient(ingredientGetter);
        }

        if (effectErrors.Count > 0)
        {
            var sb = new System.Text.StringBuilder();
            sb.AppendLine("Duplicate effects found. Please check the following ingredients and effects:");
            effectErrors.ForEach(e => sb.AppendLine(e.ToString()));


            throw new InvalidOperationException(sb.ToString());
        }
    }
}
