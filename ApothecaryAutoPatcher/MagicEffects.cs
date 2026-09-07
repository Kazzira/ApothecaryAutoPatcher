using Mutagen.Bethesda;
using Mutagen.Bethesda.Synthesis;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.FormKeys.SkyrimSE;
using Mutagen.Bethesda.WPF.Reflection.Attributes;
using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Plugins.Records;

namespace ApothecaryAutoPatcher;

public record Effect(FormLinkGetter<IMagicEffectGetter> BaseEffect, float Magnitude, int Duration);
public record EffectToEffect(FormLinkGetter<IMagicEffectGetter> EffectFrom, Effect EffectTo);

public static class MagicEffects
{
    public static readonly FormLinkGetter<IMagicEffectGetter> AlchAbsorbSpell                        = FormKey.Factory( "000812:ccBGSSSE037-Curios.esl"       ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> AlchLight                              = FormKey.Factory( "000846:ccBGSSSE037-Curios.esl"       ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> AlchNightEye                           = FormKey.Factory( "000803:ccBGSSSE037-Curios.esl"       ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> AlchWaterwalking                       = FormKey.Factory( "0390E1:Dragonborn.esm"               ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchCureParalysis                   = FormKey.Factory( "601944:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchDamageHealthRate                = FormKey.Factory( "60190B:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchDetectAnimal                    = FormKey.Factory( "60191F:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchDetectLife                      = FormKey.Factory( "60190A:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchFireDamage                      = FormKey.Factory( "601944:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchFortifySpeed                    = FormKey.Factory( "601925:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchFrostDamage                     = FormKey.Factory( "601943:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchLight                           = FormKey.Factory( "60193E:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchNightEye                        = FormKey.Factory( "6028C5:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchReflectDamage                   = FormKey.Factory( "601933:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchReflectSpell                    = FormKey.Factory( "601946:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchResistDisease                   = FormKey.Factory( "601934:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchShield                          = FormKey.Factory( "601948:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchShockDamage                     = FormKey.Factory( "60191B:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> BSKAlchWaterwalking                    = FormKey.Factory( "601906:BSAssets.esm"                 ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> MAG_AlchBecomeEthereal                 = FormKey.Factory( "0F3879:Apothecary.esp"               ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> MAG_AlchDamageIceWraith                = FormKey.Factory( "1C82E7:Apothecary.esp"               ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> MAG_AlchFortifyMovementSpeed           = FormKey.Factory( "246C21:Apothecary.esp"               ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> MAG_AlchMuffle                         = FormKey.Factory( "1FFE18:Apothecary.esp"               ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHAlchArmorDamageFFContact50          = FormKey.Factory( "690D47:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHAlchCureParalysis                   = FormKey.Factory( "3F0BB4:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHAlchFortifyUnarmedDamageFFSelf      = FormKey.Factory( "5D0EED:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHAlchFrostDamageFFContact            = FormKey.Factory( "F546EF:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHAlchResistDisease                   = FormKey.Factory( "5D0EEE:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHAlchSoulTrapFFContact               = FormKey.Factory( "954D71:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHAlchStagger                         = FormKey.Factory( "9406CD:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHDamageHealthRavageContact           = FormKey.Factory( "0A30C2:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHDamageStaminaRavageContact          = FormKey.Factory( "0A8377:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHDamageMagickaRavageContact          = FormKey.Factory( "0E6F3B:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHGFTMeleeDamagicMagicResistSkulltula = FormKey.Factory( "0B95D4:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
    public static readonly FormLinkGetter<IMagicEffectGetter> RoHPoisonCloakFFSelf                   = FormKey.Factory( "6FBDD8:RelicsofHyruleDragonborn.esp" ).ToLink<IMagicEffectGetter>();
}


public static class MagicEffectInfo
{
    public static readonly Effect AlchCureDisease           = new(Skyrim.MagicEffect.AlchCureDisease,           1.0000000f,   0);
    public static readonly Effect AlchDamageHealth          = new(Skyrim.MagicEffect.AlchDamageHealth,          0.4400000f,  10);
    public static readonly Effect AlchDamageHealthDuration  = new(Skyrim.MagicEffect.AlchDamageHealthDuration,  0.2700000f,  30);
    public static readonly Effect AlchDamageHealthRavage    = new(Skyrim.MagicEffect.AlchDamageHealthRavage,    3.3300000f,  60); //MAG_AlchDamageWeapon
    public static readonly Effect AlchDamageMagicka         = new(Skyrim.MagicEffect.AlchDamageMagicka,         0.8800000f,  10);
    public static readonly Effect AlchDamageMagickaRate     = new(Skyrim.MagicEffect.AlchDamageMagickaRate,     3.3300000f,  30); //MAG_AlchSilence
    public static readonly Effect AlchDamageMagickaRavage   = new(Skyrim.MagicEffect.AlchDamageMagickaRavage,   19.950001f,  60); //MAG_AlchDamageArmor
    public static readonly Effect AlchDamageSpeed           = new(Skyrim.MagicEffect.AlchDamageSpeed,           3.3300000f,  60); //MAG_AlchBurden
    public static readonly Effect AlchDamageStamina         = new(Skyrim.MagicEffect.AlchDamageStamina,         0.8800000f,  10);
    public static readonly Effect AlchDamageStaminaDuration = new(Skyrim.MagicEffect.AlchDamageStaminaDuration, 0.5200000f,  30);
    public static readonly Effect AlchDamageStaminaRate     = new(Skyrim.MagicEffect.AlchDamageStaminaRate,     3.3300000f,  30); //MAG_AlchCommand
    public static readonly Effect AlchDamageStaminaRavage   = new(Skyrim.MagicEffect.AlchDamageStaminaRavage,   3.3300000f,  30); //MAG_AlchCalm
    public static readonly Effect AlchFortifyAlchemy        = new(Skyrim.MagicEffect.AlchFortifyAlchemy,        3.3300000f,  60); //MAG_AlchFortifySneakAttacks
    public static readonly Effect AlchFortifyAlteration     = new(Skyrim.MagicEffect.AlchFortifyAlteration,     6.6700000f,  60);
    public static readonly Effect AlchFortifyBarter         = new(Skyrim.MagicEffect.AlchFortifyBarter,         1.3300000f, 300);
    public static readonly Effect AlchFortifyBlock          = new(Skyrim.MagicEffect.AlchFortifyBlock,          3.3300000f,  60);
    public static readonly Effect AlchFortifyCarryWeight    = new(Skyrim.MagicEffect.AlchFortifyCarryWeight,    6.6700000f, 300);
    public static readonly Effect AlchFortifyConjuration    = new(Skyrim.MagicEffect.AlchFortifyConjuration,    6.6700000f,  60); // MAG_AlchFortifyConjurationPower
    public static readonly Effect AlchFortifyDestruction    = new(Skyrim.MagicEffect.AlchFortifyDestruction,    3.3300000f,  60);
    public static readonly Effect AlchFortifyEnchanting     = new(Skyrim.MagicEffect.AlchFortifyEnchanting,     3.3300000f,  60); //MAG_AlchFortifyPowerAttacks
    public static readonly Effect AlchFortifyHealRate       = new(Skyrim.MagicEffect.AlchFortifyHealRate,       2.6700000f, 300);
    public static readonly Effect AlchFortifyHealth         = new(Skyrim.MagicEffect.AlchFortifyHealth,         2.6700000f, 300);
    public static readonly Effect AlchFortifyHeavyArmor     = new(Skyrim.MagicEffect.AlchFortifyHeavyArmor,     3.3300000f,  60); //MAG_AlchFortifyShouts
    public static readonly Effect AlchFortifyIllusion       = new(Skyrim.MagicEffect.AlchFortifyIllusion,       3.3300000f,  60);
    public static readonly Effect AlchFortifyLightArmor     = new(Skyrim.MagicEffect.AlchFortifyLightArmor,     6.6700000f, 300); //MAG_AlchFortifyArmorRating
    public static readonly Effect AlchFortifyLockpicking    = new(Skyrim.MagicEffect.AlchFortifyLockpicking,    3.3300000f,  60);
    public static readonly Effect AlchFortifyMagicka        = new(Skyrim.MagicEffect.AlchFortifyMagicka,        2.6700000f, 300);
    public static readonly Effect AlchFortifyMagickaRate    = new(Skyrim.MagicEffect.AlchFortifyMagickaRate,    2.6700000f, 300);
    public static readonly Effect AlchFortifyMarksman       = new(Skyrim.MagicEffect.AlchFortifyMarksman,       3.3300000f,  60);
    public static readonly Effect AlchFortifyOneHanded      = new(Skyrim.MagicEffect.AlchFortifyOneHanded,      3.3300000f,  60);
    public static readonly Effect AlchFortifyPickpocket     = new(Skyrim.MagicEffect.AlchFortifyPickpocket,     3.3300000f,  60);
    public static readonly Effect AlchFortifyRestoration    = new(Skyrim.MagicEffect.AlchFortifyRestoration,    3.3300000f,  60);
    public static readonly Effect AlchFortifySmithing       = new(Skyrim.MagicEffect.AlchFortifySmithing,       3.3300000f,  60); //MAG_AlchFortifyUnarmed
    public static readonly Effect AlchFortifySneak          = new(Skyrim.MagicEffect.AlchFortifySneak,          3.3300000f,  60);
    public static readonly Effect AlchFortifyStamina        = new(Skyrim.MagicEffect.AlchFortifyStamina,        2.6700000f, 300);
    public static readonly Effect AlchFortifyStaminaRate    = new(Skyrim.MagicEffect.AlchFortifyStaminaRate,    2.6700000f, 300);
    public static readonly Effect AlchFortifyTwoHanded      = new(Skyrim.MagicEffect.AlchFortifyTwoHanded,      3.3300000f,  60);
    public static readonly Effect AlchInvisibillity         = new(Skyrim.MagicEffect.AlchInvisibillity,         0.0000000f,   4);
    public static readonly Effect AlchLight                 = new(MagicEffects.AlchLight,                       0.0000000f,   4); //ccBGSSSE037_AlchLight
    public static readonly Effect AlchMuffle                = new(MagicEffects.MAG_AlchMuffle,                  1.0000000f,   4);
    public static readonly Effect AlchNightEye              = new(MagicEffects.AlchNightEye,                    0.0000000f,   4); //ccBGSSSE037_AlchNightEye
    public static readonly Effect AlchParalysis             = new(Skyrim.MagicEffect.AlchParalysis,             3.3300000f,  10);
    public static readonly Effect AlchResistFire            = new(Skyrim.MagicEffect.AlchResistFire,            3.3300000f,  60);
    public static readonly Effect AlchResistFrost           = new(Skyrim.MagicEffect.AlchResistFrost,           3.3300000f,  60);
    public static readonly Effect AlchResistMagic           = new(Skyrim.MagicEffect.AlchResistMagic,           1.6700000f, 300);
    public static readonly Effect AlchResistPoison          = new(Skyrim.MagicEffect.AlchResistPoison,          3.3300000f,  60);
    public static readonly Effect AlchResistShock           = new(Skyrim.MagicEffect.AlchResistShock,           3.3300000f,  60);
    public static readonly Effect AlchRestoreHealth         = new(Skyrim.MagicEffect.AlchRestoreHealth,         0.9600000f,  10);
    public static readonly Effect AlchRestoreMagicka        = new(Skyrim.MagicEffect.AlchRestoreMagicka,        0.9600000f,  10);
    public static readonly Effect AlchRestoreStamina        = new(Skyrim.MagicEffect.AlchRestoreStamina,        0.9600000f,  10);
    public static readonly Effect AlchWaterbreathing        = new(Skyrim.MagicEffect.AlchWaterbreathing,        0.0000000f,   4);
    public static readonly Effect AlchWaterWalking          = new(MagicEffects.AlchWaterwalking,                0.0000000f,   4);
    public static readonly Effect AlchWeaknessFire          = new(Skyrim.MagicEffect.AlchWeaknessFire,          6.6600000f,  60);
    public static readonly Effect AlchWeaknessFrost         = new(Skyrim.MagicEffect.AlchWeaknessFrost,         6.6600000f,  60);
    public static readonly Effect AlchWeaknessMagic         = new(Skyrim.MagicEffect.AlchWeaknessMagic,         2.6700000f,  60); //MAG_AlchReflectDamage
    public static readonly Effect AlchWeaknessPoison        = new(Skyrim.MagicEffect.AlchWeaknessPoison,        6.6600000f,  60);
    public static readonly Effect AlchWeaknessShock         = new(Skyrim.MagicEffect.AlchWeaknessShock,         6.6600000f,  60);
    public static readonly Effect AlchInfluenceAggUp        = new(Skyrim.MagicEffect.AlchInfluenceAggUp,        3.3300000f,  30);
    public static readonly Effect AlchInfluenceConfDown     = new(Skyrim.MagicEffect.AlchInfluenceConfDown,     3.3300000f,  30); /// MAG_AlchFear
    public static readonly Effect AlchAbsorbSpell           = new(MagicEffects.AlchAbsorbSpell,                 1.6700000f,  60); //ccBGSSSE037_AlchAbsorbSpell
    public static readonly Effect MAG_AlchBecomeEthereal    = new(MagicEffects.MAG_AlchBecomeEthereal,          0.0000000f,   4);
    public static readonly Effect MAG_FortifyMovementSpeed  = new(MagicEffects.MAG_AlchFortifyMovementSpeed,    1.3300000f,  60);
}



