using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dnd123.Models.Character
{
    public enum Abilities : int
    {
        [Display(Name = "Acid Splash")]
        AcidSplash = 0,
        [Display(Name = "Arcane Weapon")]
        ArcaneWeapon = 1,
        [Display(Name = "Astral Projection")]
        AstralProjection = 2,
        Barkskin = 4,
        Bless = 6,
        [Display(Name = "Burning Hands")]
        BurningHands = 8,
        [Display(Name = "Call Lightning")]
        CallLightning = 10,
        [Display(Name = "Chaos Bolt")]
        ChaosBolt = 12,
        [Display(Name = "Chain Lightning")]
        ChainLightning = 14,
        [Display(Name = "Chill Touch")]
        ChillTouch = 16,
        [Display(Name = "Cloud of Daggers")]
        CloudofDaggers = 18,
        [Display(Name = "Crown of Stars")]
        CrownofStars = 20,
        [Display(Name = "Cure Wounds")]
        CureWounds = 22,
        [Display(Name = "Dark Star")]
        DarkStar = 24,
        [Display(Name = "Dragon's Breath")]
        DragonsBreath = 26,
        [Display(Name = "Detect Magic")]
        DetectMagic = 28,
        [Display(Name = "Dispel Magic")]
        DispelMagic = 30,
        Druidcraft = 32,
        [Display(Name = "Dust Devil")]
        DustDevil = 34,
        [Display(Name = "Earth Tremor")]
        EarthTremor = 36,
        Entangle = 38,
        [Display(Name = "Find Traps")]
        FindTraps = 40,
        Fireball = 42,
        Firebolt = 44,
        Flamestrike = 46,
        [Display(Name = "Frost Fingers")]
        FrostFingers = 48,
        Frostbite = 50,
        [Display(Name = "Healing Spirit")]
        HealingSpirit = 52,
        [Display(Name = "Healing Word")]
        HealingWord = 54,
        [Display(Name = "Ice Knife")]
        IceKnife = 56,
        [Display(Name = "Ice Storm")]
        IceStorm = 58,
        Invisibility = 60,
        [Display(Name = "Lightning Arrow")]
        LightningArrow = 62,
        [Display(Name = "Lightning Bolt")]
        LightningBolt = 64,
        [Display(Name = "Magic Stone")]
        MagicStone = 66,
        [Display(Name = "Magic Missile")]
        MagicMissile = 68,
        Mending = 70,
        [Display(Name = "Mind Sliver")]
        MindSliver = 72,
        [Display(Name = "Mind Spike")]
        MindSpike = 74,
        Moonbeam = 76,
        [Display(Name = "Poison Spray")]
        PoisonSpray = 78,
        [Display(Name = "Ray of Frost")]
        RayofFrost = 80,
        [Display(Name = "Sacred Flame")]
        SacredFlame = 82,
        [Display(Name = "Shadow Blade")]
        ShadowBlade = 84,
        [Display(Name = "Shape Water")]
        ShapeWater = 86,
        [Display(Name = "Shield of Faith")]
        ShieldofFaith = 88,
        Silence = 90,
        [Display(Name = "Storm Sphere")]
        StormSphere = 92,
        [Display(Name = "Summon Fey")]
        SummonFey = 94,
        [Display(Name = "Summon Shadowspawn")]
        SummonShadowspawn = 96,
        [Display(Name = "Summon Undead")]
        SummonUndead = 98,
        Sunburst = 100,
        [Display(Name = "Thorn Whip")]
        ThornWhip = 102,
        [Display(Name = "Tidal Wave")]
        TidalWave = 104,
        [Display(Name = "True Strike")]
        TrueStrike = 106,
        [Display(Name = "Vampiric Touch")]
        VampiricTouch = 108,
        [Display(Name = "Wall of Ice")]
        WallofIce = 110,
        [Display(Name = "Wall of Thorns")]
        WallofThorns = 112,
        [Display(Name = "Watery Sphere")]
        WaterySphere = 114,
        [Display(Name = "Witch Bold")]
        WitchBold = 116,
        [Display(Name = "Wrathful Smite")]
        WrathfulSmite = 118
    }
}
