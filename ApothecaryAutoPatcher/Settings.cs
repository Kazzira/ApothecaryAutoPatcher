using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Plugins;

namespace ApothecaryAutoPatcher;


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
        new(Skyrim.MagicEffect.AlchCureDisease,                  MagicEffectInfoLists.AlchCureDisease),
        new(Skyrim.MagicEffect.AlchCurePoison,                   MagicEffectInfoLists.AlchResistPoison),
        new(Skyrim.MagicEffect.AlchDamageHealth,                 MagicEffectInfoLists.AlchDamageHealth),
        new(Skyrim.MagicEffect.AlchDamageHealthDuration,         MagicEffectInfoLists.AlchDamageHealthDuration),
        new(Skyrim.MagicEffect.AlchDamageHealthRavage,           MagicEffectInfoLists.AlchDamageHealthRavage), //MAG_AlchDamageWeapon
        new(Skyrim.MagicEffect.AlchDamageMagicka,                MagicEffectInfoLists.AlchDamageMagicka),
        new(Skyrim.MagicEffect.AlchDamageMagickaDuration,        MagicEffectInfoLists.AlchDamageMagickaDuration),
        new(Skyrim.MagicEffect.AlchDamageMagickaRate,            MagicEffectInfoLists.AlchDamageMagickaRate), //MAG_AlchSilence
        new(Skyrim.MagicEffect.AlchDamageMagickaRavage,          MagicEffectInfoLists.AlchDamageMagickaRavage), //MAG_AlchDamageArmor
        new(Skyrim.MagicEffect.AlchDamageSpeed,                  MagicEffectInfoLists.AlchDamageSpeed), //MAG_AlchBurden
        new(Skyrim.MagicEffect.AlchDamageStamina,                MagicEffectInfoLists.AlchDamageStamina),
        new(Skyrim.MagicEffect.AlchDamageStaminaDuration,        MagicEffectInfoLists.AlchDamageStaminaDuration),
        new(Skyrim.MagicEffect.AlchDamageStaminaRavage,          MagicEffectInfoLists.AlchDamageStaminaRavage), //MAG_AlchCalm
        new(Skyrim.MagicEffect.AlchDamageStaminaRate,            MagicEffectInfoLists.AlchDamageStaminaRate), //MAG_AlchCommand
        new(Skyrim.MagicEffect.AlchFortifyAlchemy,               MagicEffectInfoLists.AlchFortifyAlchemy), //MAG_AlchFortifySneakAttacks
        new(Skyrim.MagicEffect.AlchFortifyBarter,                MagicEffectInfoLists.AlchFortifyBarter),
        new(Skyrim.MagicEffect.AlchFortifyBlock,                 MagicEffectInfoLists.AlchFortifyBlock),
        new(Skyrim.MagicEffect.AlchFortifyCarryWeight,           MagicEffectInfoLists.AlchFortifyCarryWeight),
        new(Skyrim.MagicEffect.AlchFortifyAlteration,            MagicEffectInfoLists.AlchFortifyAlteration),
        new(Skyrim.MagicEffect.AlchFortifyConjuration,           MagicEffectInfoLists.AlchFortifyConjuration),
        new(Skyrim.MagicEffect.AlchFortifyDestruction,           MagicEffectInfoLists.AlchFortifyDestruction),
        new(Skyrim.MagicEffect.AlchFortifyEnchanting,            MagicEffectInfoLists.AlchFortifyEnchanting), //MAG_AlchFortifyPowerAttacks
        new(Skyrim.MagicEffect.AlchFortifyHealRate,              MagicEffectInfoLists.AlchFortifyHealRate),
        new(Skyrim.MagicEffect.AlchFortifyHealth,                MagicEffectInfoLists.AlchFortifyHealth),
        new(Skyrim.MagicEffect.AlchFortifyHeavyArmor,            MagicEffectInfoLists.AlchFortifyHeavyArmor), //MAG_AlchFortifyShouts
        new(Skyrim.MagicEffect.AlchFortifyIllusion,              MagicEffectInfoLists.AlchFortifyIllusion),
        new(Skyrim.MagicEffect.AlchFortifyLightArmor,            MagicEffectInfoLists.AlchFortifyLightArmor), //MAG_AlchFortifyArmorRating
        new(Skyrim.MagicEffect.AlchFortifyLockpicking,           MagicEffectInfoLists.AlchFortifyLockpicking),
        new(Skyrim.MagicEffect.AlchFortifyMagicka,               MagicEffectInfoLists.AlchFortifyMagicka),
        new(Skyrim.MagicEffect.AlchFortifyMagickaRate,           MagicEffectInfoLists.AlchFortifyMagickaRate),
        new(Skyrim.MagicEffect.AlchFortifyMarksman,              MagicEffectInfoLists.AlchFortifyMarksman),
        new(Skyrim.MagicEffect.AlchFortifyOneHanded,             MagicEffectInfoLists.AlchFortifyOneHanded),
        new(Skyrim.MagicEffect.AlchFortifyPersuasion,            MagicEffectInfoLists.AlchFortifyPersuasion),
        new(Skyrim.MagicEffect.AlchFortifyPickpocket,            MagicEffectInfoLists.AlchFortifyPickpocket),
        new(Skyrim.MagicEffect.AlchFortifyRestoration,           MagicEffectInfoLists.AlchFortifyRestoration),
        new(Skyrim.MagicEffect.AlchFortifySmithing,              MagicEffectInfoLists.AlchFortifySmithing), //MAG_AlchFortifyUnarmed
        new(Skyrim.MagicEffect.AlchFortifySneak,                 MagicEffectInfoLists.AlchFortifySneak),
        new(Skyrim.MagicEffect.AlchFortifyStamina,               MagicEffectInfoLists.AlchFortifyStamina),
        new(Skyrim.MagicEffect.AlchFortifyStaminaRate,           MagicEffectInfoLists.AlchFortifyStaminaRate),
        new(Skyrim.MagicEffect.AlchFortifyTwoHanded,             MagicEffectInfoLists.AlchFortifyTwoHanded),
        new(Skyrim.MagicEffect.AlchInfluenceConfDown,            MagicEffectInfoLists.AlchInfluenceConfDown),
        new(Skyrim.MagicEffect.AlchInfluenceAggUp,               MagicEffectInfoLists.AlchInfluenceAggUp),
        new(Skyrim.MagicEffect.AlchInvisibillity,                MagicEffectInfoLists.AlchInvisibillity),
        new(Skyrim.MagicEffect.AlchParalysis,                    MagicEffectInfoLists.AlchParalysis),
        new(Skyrim.MagicEffect.AlchResistFire,                   MagicEffectInfoLists.AlchResistFire),
        new(Skyrim.MagicEffect.AlchResistFrost,                  MagicEffectInfoLists.AlchResistFrost),
        new(Skyrim.MagicEffect.AlchResistMagic,                  MagicEffectInfoLists.AlchResistMagic),
        new(Skyrim.MagicEffect.AlchResistPoison,                 MagicEffectInfoLists.AlchResistPoison),
        new(Skyrim.MagicEffect.AlchResistShock,                  MagicEffectInfoLists.AlchResistShock),
        new(Skyrim.MagicEffect.AlchRestoreHealth,                MagicEffectInfoLists.AlchRestoreHealth),
        new(Skyrim.MagicEffect.AlchRestoreHealthAll,             MagicEffectInfoLists.AlchRestoreHealth),
        new(Skyrim.MagicEffect.AlchRestoreMagicka,               MagicEffectInfoLists.AlchRestoreMagicka),
        new(Skyrim.MagicEffect.AlchRestoreMagickaAll,            MagicEffectInfoLists.AlchRestoreMagicka),
        new(Skyrim.MagicEffect.AlchRestoreStamina,               MagicEffectInfoLists.AlchRestoreStamina),
        new(Skyrim.MagicEffect.AlchRestoreStaminaAll,            MagicEffectInfoLists.AlchRestoreStamina),
        new(Skyrim.MagicEffect.AlchWaterbreathing,               MagicEffectInfoLists.AlchWaterbreathing),
        new(Skyrim.MagicEffect.AlchWeaknessFire,                 MagicEffectInfoLists.AlchWeaknessFire),
        new(Skyrim.MagicEffect.AlchWeaknessFrost,                MagicEffectInfoLists.AlchWeaknessFrost),
        new(Skyrim.MagicEffect.AlchWeaknessMagic,                MagicEffectInfoLists.AlchWeaknessMagic), //MAG_AlchReflectDamage
        new(Skyrim.MagicEffect.AlchWeaknessPoison,               MagicEffectInfoLists.AlchWeaknessPoison),
        new(Skyrim.MagicEffect.AlchWeaknessShock,                MagicEffectInfoLists.AlchWeaknessShock),
        new(Skyrim.MagicEffect.FireCloakFFSelf,                  MagicEffectInfoLists.FireCloakFFSelf),
        new(Skyrim.MagicEffect.FrostCloakFFSelf,                 MagicEffectInfoLists.FrostCloakFFSelf),
        new(Skyrim.MagicEffect.ShockCloakFFSelf,                 MagicEffectInfoLists.ShockCloakFFSelf),
        new(MagicEffects.AlchAbsorbSpell,                        MagicEffectInfoLists.AlchAbsorbSpell), //ccBGSSSE037_AlchAbsorbSpell
        new(MagicEffects.AlchLight,                              MagicEffectInfoLists.AlchLight), //ccBGSSSE037_AlchLight
        new(MagicEffects.AlchNightEye,                           MagicEffectInfoLists.AlchNightEye), //ccBGSSSE037_AlchNightEye
        new(MagicEffects.BSKAlchCureParalysis,                   MagicEffectInfoLists.BSKAlchCureParalysis),
        new(MagicEffects.BSKAlchDamageHealthRate,                MagicEffectInfoLists.BSKAlchDamageHealthRate),
        new(MagicEffects.BSKAlchDetectAnimal,                    MagicEffectInfoLists.BSKAlchDetectAnimal),
        new(MagicEffects.BSKAlchDetectLife,                      MagicEffectInfoLists.BSKAlchDetectLife),
        new(MagicEffects.BSKAlchFireDamage,                      MagicEffectInfoLists.BSKAlchFireDamage),
        new(MagicEffects.BSKAlchFortifySpeed,                    MagicEffectInfoLists.BSKAlchFortifySpeed),
        new(MagicEffects.BSKAlchFrostDamage,                     MagicEffectInfoLists.BSKAlchFrostDamage),
        new(MagicEffects.BSKAlchLight,                           MagicEffectInfoLists.BSKAlchLight),
        new(MagicEffects.BSKAlchNightEye,                        MagicEffectInfoLists.BSKAlchNightEye),
        new(MagicEffects.BSKAlchReflectDamage,                   MagicEffectInfoLists.BSKAlchReflectDamage),
        new(MagicEffects.BSKAlchReflectSpell,                    MagicEffectInfoLists.BSKAlchReflectSpell),
        new(MagicEffects.BSKAlchResistDisease,                   MagicEffectInfoLists.BSKAlchResistDisease),
        new(MagicEffects.BSKAlchShield,                          MagicEffectInfoLists.BSKAlchShield),
        new(MagicEffects.BSKAlchShockDamage,                     MagicEffectInfoLists.BSKAlchShockDamage),
        new(MagicEffects.BSKAlchWaterwalking,                    MagicEffectInfoLists.BSKAlchWaterwalking),
        new(MagicEffects.RoHAlchArmorDamageFFContact50,          MagicEffectInfoLists.RoHAlchArmorDamageFFContact50),
        new(MagicEffects.RoHAlchCureParalysis,                   MagicEffectInfoLists.RoHAlchCureParalysis),
        new(MagicEffects.RoHAlchFortifyUnarmedDamageFFSelf,      MagicEffectInfoLists.RoHAlchFortifyUnarmedDamageFFSelf),
        new(MagicEffects.RoHAlchFrostDamageFFContact,            MagicEffectInfoLists.RoHAlchFrostDamageFFContact),
        new(MagicEffects.RoHAlchResistDisease,                   MagicEffectInfoLists.RoHAlchResistDisease),
        new(MagicEffects.RoHAlchSoulTrapFFContact,               MagicEffectInfoLists.RoHAlchSoulTrapFFContact),
        new(MagicEffects.RoHAlchStagger,                         MagicEffectInfoLists.RoHAlchStagger),
        new(MagicEffects.RoHDamageHealthRavageContact,           MagicEffectInfoLists.RoHDamageHealthRavageContact),
        new(MagicEffects.RoHDamageMagickaRavageContact,          MagicEffectInfoLists.RoHDamageMagickaRavageContact),
        new(MagicEffects.RoHDamageStaminaRavageContact,          MagicEffectInfoLists.RoHDamageStaminaRavageContact),
        new(MagicEffects.RoHGFTMeleeDamagicMagicResistSkulltula, MagicEffectInfoLists.RoHGFTMeleeDamagicMagicResistSkulltula),
        new(MagicEffects.RoHPoisonCloakFFSelf,                   MagicEffectInfoLists.RoHPoisonCloakFFSelf),
    };

    /// <summary>
    /// The list of ingredients to blacklist.
    /// </summary>
    /// <remarks>This list contains the ingredients that should not be patched. This is useful for ingredients that are not meant to be used in the patcher.</remarks>
    public List<FormLink<IIngredientGetter>> Blacklist = new()
    {
        Skyrim.Ingredient.DBJarrinRoot
    };

    [SettingName("Duplicate Effect Is Stop Error")]
    public bool DuplicateEffectIsStopError = true;
}