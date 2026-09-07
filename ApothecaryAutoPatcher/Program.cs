using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;

namespace ApothecaryAutoPatcher
{
    /// <summary>
    /// Settings class for the Apothecary Auto Patcher.
    /// </summary>
    public class Settings
    {
    
        /// <summary>
        /// The list of effects to override.
        /// </summary>
        [SettingName("Effects")]
        public List<EffectToEffect> Effects = new() {
            new(Skyrim.MagicEffect.AlchCureDisease,             MagicEffectInfo.AlchCureDisease),
            new(Skyrim.MagicEffect.AlchCurePoison,              MagicEffectInfo.AlchResistPoison),
            new(Skyrim.MagicEffect.AlchDamageHealth,            MagicEffectInfo.AlchDamageHealth),
            new(Skyrim.MagicEffect.AlchDamageHealthDuration,    MagicEffectInfo.AlchDamageHealthDuration),
            new(Skyrim.MagicEffect.AlchDamageHealthRavage,      MagicEffectInfo.AlchDamageWeapon), //MAG_AlchDamageWeapon
            new(Skyrim.MagicEffect.AlchDamageMagicka,           MagicEffectInfo.AlchDamageMagicka),
            new(Skyrim.MagicEffect.AlchDamageMagickaDuration,   MagicEffectInfo.AlchDamageMagickaDuration),
            new(Skyrim.MagicEffect.AlchDamageMagickaRate,       MagicEffectInfo.AlchSilence), //MAG_AlchSilence
            new(Skyrim.MagicEffect.AlchDamageMagickaRavage,     MagicEffectInfo.AlchDamageArmor), //MAG_AlchDamageArmor
            new(Skyrim.MagicEffect.AlchDamageSpeed,             MagicEffectInfo.AlchBurden), //MAG_AlchBurden
            new(Skyrim.MagicEffect.AlchDamageStamina,           MagicEffectInfo.AlchDamageStamina),
            new(Skyrim.MagicEffect.AlchDamageStaminaDuration,   MagicEffectInfo.AlchDamageStaminaDuration),
            new(Skyrim.MagicEffect.AlchDamageStaminaRavage,     MagicEffectInfo.MAG_AlchCalm), //MAG_AlchCalm
            new(Skyrim.MagicEffect.AlchDamageStaminaRate,       MagicEffectInfo.AlchCommand), //MAG_AlchCommand
            new(Skyrim.MagicEffect.AlchFortifyAlchemy,          MagicEffectInfo.AlchFortifySneakAttacks), //MAG_AlchFortifySneakAttacks
            new(Skyrim.MagicEffect.AlchFortifyBarter,           MagicEffectInfo.AlchFortifyBarter),
            new(Skyrim.MagicEffect.AlchFortifyBlock,            MagicEffectInfo.AlchFortifyBlock),
            new(Skyrim.MagicEffect.AlchFortifyCarryWeight,      MagicEffectInfo.AlchFortifyCarryWeight),
            new(Skyrim.MagicEffect.AlchFortifyAlteration,       MagicEffectInfo.AlchFortifyAlteration),
            new(Skyrim.MagicEffect.AlchFortifyConjuration,      MagicEffectInfo.AlchFortifyConjuration),
            new(Skyrim.MagicEffect.AlchFortifyDestruction,      MagicEffectInfo.AlchFortifyDestruction),
            new(Skyrim.MagicEffect.AlchFortifyEnchanting,       MagicEffectInfo.AlchFortifyPowerAttacks), //MAG_AlchFortifyPowerAttacks
            new(Skyrim.MagicEffect.AlchFortifyHealRate,         MagicEffectInfo.AlchFortifyHealRate),
            new(Skyrim.MagicEffect.AlchFortifyHealth,           MagicEffectInfo.AlchFortifyHealth),
            new(Skyrim.MagicEffect.AlchFortifyHeavyArmor,       MagicEffectInfo.AlchFortifyShouts), //MAG_AlchFortifyShouts
            new(Skyrim.MagicEffect.AlchFortifyIllusion,         MagicEffectInfo.AlchFortifyIllusion),
            new(Skyrim.MagicEffect.AlchFortifyLightArmor,       MagicEffectInfo.AlchFortifyArmorRating), //MAG_AlchFortifyArmorRating
            new(Skyrim.MagicEffect.AlchFortifyLockpicking,      MagicEffectInfo.AlchFortifyLockpicking),
            new(Skyrim.MagicEffect.AlchFortifyMagicka,          MagicEffectInfo.AlchFortifyMagicka),
            new(Skyrim.MagicEffect.AlchFortifyMagickaRate,      MagicEffectInfo.AlchFortifyMagickaRate),
            new(Skyrim.MagicEffect.AlchFortifyMarksman,         MagicEffectInfo.AlchFortifyMarksman),
            new(Skyrim.MagicEffect.AlchFortifyOneHanded,        MagicEffectInfo.AlchFortifyOneHanded),
            new(Skyrim.MagicEffect.AlchFortifyPickpocket,       MagicEffectInfo.AlchFortifyPickpocket),
            new(Skyrim.MagicEffect.AlchFortifyRestoration,      MagicEffectInfo.AlchFortifyRestoration),
            new(Skyrim.MagicEffect.AlchFortifySmithing,         MagicEffectInfo.AlchFortifyUnarmed), //MAG_AlchFortifyUnarmed
            new(Skyrim.MagicEffect.AlchFortifySneak,            MagicEffectInfo.AlchFortifySneak),
            new(Skyrim.MagicEffect.AlchFortifyStamina,          MagicEffectInfo.AlchFortifyStamina),
            new(Skyrim.MagicEffect.AlchFortifyStaminaRate,      MagicEffectInfo.AlchFortifyStaminaRate),
            new(Skyrim.MagicEffect.AlchFortifyTwoHanded,        MagicEffectInfo.AlchFortifyTwoHanded),
            new(Skyrim.MagicEffect.AlchInfluenceConfDown,       MagicEffectInfo.MAG_AlchFear),
            new(Skyrim.MagicEffect.AlchInfluenceAggUp,          MagicEffectInfo.AlchInfluenceAggUp),
            new(Skyrim.MagicEffect.AlchInvisibillity,           MagicEffectInfo.AlchInvisibillity),
            new(Skyrim.MagicEffect.AlchParalysis,               MagicEffectInfo.AlchParalysis),
            new(Skyrim.MagicEffect.AlchResistFire,              MagicEffectInfo.AlchResistFire),
            new(Skyrim.MagicEffect.AlchResistFrost,             MagicEffectInfo.AlchResistFrost),
            new(Skyrim.MagicEffect.AlchResistMagic,             MagicEffectInfo.AlchResistMagic),
            new(Skyrim.MagicEffect.AlchResistPoison,            MagicEffectInfo.AlchResistPoison),
            new(Skyrim.MagicEffect.AlchResistShock,             MagicEffectInfo.AlchResistShock),
            new(Skyrim.MagicEffect.AlchRestoreHealth,           MagicEffectInfo.AlchRestoreHealth),
            new(Skyrim.MagicEffect.AlchRestoreHealthAll,        MagicEffectInfo.AlchRestoreHealth),
            new(Skyrim.MagicEffect.AlchRestoreMagicka,          MagicEffectInfo.AlchRestoreMagicka),
            new(Skyrim.MagicEffect.AlchRestoreMagickaAll,       MagicEffectInfo.AlchRestoreMagicka),
            new(Skyrim.MagicEffect.AlchRestoreStamina,          MagicEffectInfo.AlchRestoreStamina),
            new(Skyrim.MagicEffect.AlchRestoreStaminaAll,       MagicEffectInfo.AlchRestoreStamina),
            new(Skyrim.MagicEffect.AlchWaterbreathing,          MagicEffectInfo.AlchWaterbreathing),
            new(Skyrim.MagicEffect.AlchWeaknessFire,            MagicEffectInfo.AlchWeaknessFire),
            new(Skyrim.MagicEffect.AlchWeaknessFrost,           MagicEffectInfo.AlchWeaknessFrost),
            new(Skyrim.MagicEffect.AlchWeaknessMagic,           MagicEffectInfo.AlchWeaknessMagic), //MAG_AlchReflectDamage
            new(Skyrim.MagicEffect.AlchWeaknessPoison,          MagicEffectInfo.AlchWeaknessPoison),
            new(Skyrim.MagicEffect.AlchWeaknessShock,           MagicEffectInfo.AlchWeaknessShock),
            new(Skyrim.MagicEffect.FireCloakFFSelf,             MagicEffectInfo.AlchMuffle),
            new(Skyrim.MagicEffect.FrostCloakFFSelf,            MagicEffectInfo.AlchParalysis),
            new(Skyrim.MagicEffect.ShockCloakFFSelf,            MagicEffectInfo.AlchDamageStamina),
            new(MagicEffects.AlchAbsorbSpell,                   MagicEffectInfo.AlchAbsorbSpell), //ccBGSSSE037_AlchAbsorbSpell
            new(MagicEffects.AlchLight,                         MagicEffectInfo.AlchLight), //ccBGSSSE037_AlchLight
            new(MagicEffects.AlchNightEye,                      MagicEffectInfo.AlchNightEye), //ccBGSSSE037_AlchNightEye
            new(MagicEffects.BSKAlchCureParalysis,              MagicEffectInfo.AlchNightEye),
            new(MagicEffects.BSKAlchDamageHealthRate,           MagicEffectInfo.AlchDamageHealthDuration),
            new(MagicEffects.BSKAlchDetectAnimal,               MagicEffectInfo.MAG_AlchFear),
            new(MagicEffects.BSKAlchDetectLife,                 MagicEffectInfo.AlchFortifyUnarmed),
            new(MagicEffects.BSKAlchFireDamage,                 MagicEffectInfo.AlchSilence),
            new(MagicEffects.BSKAlchFortifySpeed,               MagicEffectInfo.MAG_FortifyMovementSpeed),
            new(MagicEffects.BSKAlchFrostDamage,                MagicEffectInfo.AlchWeaknessFrost),
            new(MagicEffects.BSKAlchLight,                      MagicEffectInfo.AlchLight),
            new(MagicEffects.BSKAlchNightEye,                   MagicEffectInfo.AlchNightEye),
            new(MagicEffects.BSKAlchReflectDamage,              MagicEffectInfo.AlchWeaknessMagic),
            new(MagicEffects.BSKAlchReflectSpell,               MagicEffectInfo.AlchAbsorbSpell),
            new(MagicEffects.BSKAlchResistDisease,              MagicEffectInfo.AlchResistPoison),
            new(MagicEffects.BSKAlchShield,                     MagicEffectInfo.AlchFortifyBlock),
            new(MagicEffects.BSKAlchShockDamage,                MagicEffectInfo.AlchWeaknessShock),
            new(MagicEffects.BSKAlchWaterwalking,               MagicEffectInfo.AlchWaterWalking),
            new(MagicEffects.RoHAlchArmorDamageFFContact50,     MagicEffectInfo.AlchDamageArmor),
            new(MagicEffects.RoHAlchCureParalysis,              MagicEffectInfo.AlchCureDisease),
            new(MagicEffects.RoHAlchFortifyUnarmedDamageFFSelf, MagicEffectInfo.AlchFortifyUnarmed),
            new(MagicEffects.RoHAlchFrostDamageFFContact,       MagicEffectInfo.AlchWeaknessFrost),
            new(MagicEffects.RoHAlchResistDisease,              MagicEffectInfo.AlchResistPoison),
            new(MagicEffects.RoHAlchSoulTrapFFContact,          MagicEffectInfo.MAG_FortifyMovementSpeed),
            new(MagicEffects.RoHAlchStagger,                    MagicEffectInfo.MAG_AlchCalm),
        };

        /// <summary>
        /// The list of ingredients to blacklist.
        /// </summary>
        /// <remarks>This list contains the ingredients that should not be patched. This is useful for ingredients that are not meant to be used in the patcher.</remarks>
        public List<FormLink<IIngredientGetter>> Blacklist = new()
        {
            Skyrim.Ingredient.DBJarrinRoot
        };
    }

/// <summary>
/// A record to hold the effect data for each ingredient. This is used to override the effects of the ingredients in the patcher.
/// </summary>
/// <param name="BaseEffect">The base effect of the ingredient.</param>
/// <param name="Magnitude">The magnitude of the effect.</param>
/// <param name="Duration">The duration of the effect.</param>
/// <remarks>This record is used to store the effect data for each ingredient. It is used to override the effects of the ingredients in the patcher.</remarks>
/// <example>
/// var effect = new Effect(Skyrim.MagicEffect.AlchRestoreHealth, 0.96f, 10);
/// </example>

    public class Program
    {
        static Lazy<Settings> Settings = null!;

        public static async Task<int> Main(string[] args)
        {
            return await SynthesisPipeline.Instance
                .AddPatch<ISkyrimMod, ISkyrimModGetter>(RunPatch)
                .SetAutogeneratedSettings(
                    nickname: "Settings",
                    path: "settings.json",
                    out Settings)
                .SetTypicalOpen(GameRelease.SkyrimSE, "YourPatcher.esp")
                .Run(args);
        }

        /// <summary>
        /// The main patching method. This method is called by the Synthesis pipeline to run the patcher.
        /// </summary>
        /// <param name="state">The state of the patcher.</param>
        /// <remarks>This method is called by the Synthesis pipeline to run the patcher. It is responsible for patching the ingredients in the load order.</remarks>
        public static void RunPatch(IPatcherState<ISkyrimMod, ISkyrimModGetter> state)
        {
            var effectDictionary = Settings.Value.Effects.ToDictionary(e => e.EffectFrom.FormKey, e => e.EffectTo);
    
            foreach (var ingredientGetter in state.LoadOrder.PriorityOrder.Ingredient().WinningOverrides())
            {
                if (Settings.Value.Blacklist.Contains(ingredientGetter.ToLink())) continue;

                var ingredientoverride = ingredientGetter.DeepCopy();
                var overridden        = false;

                foreach (var effect in ingredientoverride.Effects)
                {
                    if (effect.Data == null) continue;

                    if (effectDictionary.TryGetValue(effect.BaseEffect.FormKey, out var effectTo))
                    {
                        // No clue if this will convert. Will need to test.
                        effect.BaseEffect.FormKey = effectTo.BaseEffect.FormKey;
                        effect.Data.Magnitude     = effectTo.Magnitude;
                        effect.Data.Duration      = effectTo.Duration;
                        overridden                = true;
                    }
                }

                if (overridden)
                {
                    state.PatchMod.Ingredients.Set(ingredientoverride);
                    Console.WriteLine(ingredientoverride.EditorID);
                }
            }
        }
    }
}
