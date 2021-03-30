using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dnd123.Models.Character
{
    public enum Abilities
    {
        [Display(Name = "Acid Splash")]
        AcidSplash,
        [Display(Name = "Arcane Weapon")]
        ArcaneWeapon,
        [Display(Name = "Astral Projection")]
        AstralProjection,
        Barkskin,
        Bless,
        [Display(Name = "Burning Hands")]
        BurningHands,
        [Display(Name = "Call Lightning")]
        CallLightning,
        [Display(Name = "Chaos Bolt")]
        ChaosBolt,
        [Display(Name = "Chain Lightning")]
        ChainLightning,
        [Display(Name = "Chill Touch")]
        ChillTouch,
        [Display(Name = "Cloud of Daggers")]
        CloudofDaggers,
        [Display(Name = "Crown of Stars")]
        CrownofStars,
        [Display(Name = "Cure Wounds")]
        CureWounds,
        [Display(Name = "Dark Star")]
        DarkStar,
        [Display(Name = "Dragon's Breath")]
        DragonsBreath,
        [Display(Name = "Detect Magic")]
        DetectMagic,
        [Display(Name = "Dispel Magic")]
        DispelMagic,
        Druidcraft,
        [Display(Name = "Dust Devil")]
        DustDevil,
        [Display(Name = "Earth Tremor")]
        EarthTremor,
        Entangle,
        [Display(Name = "Find Traps")]
        FindTraps,
        Fireball,
        Firebolt,
        Flamestrike,
        [Display(Name = "Frost Fingers")]
        FrostFingers,
        Frostbite,
        [Display(Name = "Healing Spirit")]
        HealingSpirit,
        [Display(Name = "Healing Word")]
        HealingWord,
        [Display(Name = "Ice Knife")]
        IceKnife,
        [Display(Name = "Ice Storm")]
        IceStorm,
        Invisibility,
        [Display(Name = "Lightning Arrow")]
        LightningArrow,
        [Display(Name = "Lightning Bolt")]
        LightningBolt,
        [Display(Name = "Magic Stone")]
        MagicStone,
        [Display(Name = "Magic Missile")]
        MagicMissile,
        Mending,
        [Display(Name = "Mind Sliver")]
        MindSliver,
        [Display(Name = "Mind Spike")]
        MindSpike,
        Moonbeam,
        [Display(Name = "Poison Spray")]
        PoisonSpray,
        [Display(Name = "Ray of Frost")]
        RayofFrost,
        [Display(Name = "Sacred Flame")]
        SacredFlame,
        [Display(Name = "Shadow Blade")]
        ShadowBlade,
        [Display(Name = "Shape Water")]
        ShapeWater,
        [Display(Name = "Shield of Faith")]
        ShieldofFaith,
        Silence,
        [Display(Name = "Storm Sphere")]
        StormSphere,
        [Display(Name = "Summon Fey")]
        SummonFey,
        [Display(Name = "Summon Shadowspawn")]
        SummonShadowspawn,
        [Display(Name = "Summon Undead")]
        SummonUndead,
        Sunburst,
        [Display(Name = "Thorn Whip")]
        ThornWhip,
        [Display(Name = "Tidal Wave")]
        TidalWave,
        [Display(Name = "True Strike")]
        TrueStrike,
        [Display(Name = "Vampiric Touch")]
        VampiricTouch,
        [Display(Name = "Wall of Ice")]
        WallofIce,
        [Display(Name = "Wall of Thorns")]
        WallofThorns,
        [Display(Name = "Watery Sphere")]
        WaterySphere,
        [Display(Name = "Witch Bolt")]
        WitchBolt,
        [Display(Name = "Wrathful Smite")]
        WrathfulSmite
    }
}
