using dnd123.Models.Character;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.ViewModels
{
    public class AddCharacterViewModel
    {
        [Required(ErrorMessage = "Name is required.")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Name must be between 3 and 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Bio is required")]
        [StringLength(500, ErrorMessage = "Bio too long!")]
        public string Bio { get; set; }

        public CharacterClass CharacterClass { get; set; }

        public List<SelectListItem> CharacterClasss { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(CharacterClass.Barbarian.ToString(), ((int)CharacterClass.Barbarian).ToString()),
            new SelectListItem(CharacterClass.Bard.ToString(), ((int)CharacterClass.Bard).ToString()),
            new SelectListItem(CharacterClass.Cleric.ToString(), ((int)CharacterClass.Cleric).ToString()),
            new SelectListItem(CharacterClass.Druid.ToString(), ((int)CharacterClass.Druid).ToString()),
            new SelectListItem(CharacterClass.Fighter.ToString(), ((int)CharacterClass.Fighter).ToString()),
            new SelectListItem(CharacterClass.Monk.ToString(), ((int)CharacterClass.Monk).ToString()),
            new SelectListItem(CharacterClass.Paladin.ToString(), ((int)CharacterClass.Paladin).ToString()),
            new SelectListItem(CharacterClass.Ranger.ToString(), ((int)CharacterClass.Ranger).ToString()),
            new SelectListItem(CharacterClass.Rogue.ToString(), ((int)CharacterClass.Rogue).ToString()),
            new SelectListItem(CharacterClass.Sorcerer.ToString(), ((int)CharacterClass.Sorcerer).ToString()),
            new SelectListItem(CharacterClass.Warlock.ToString(), ((int)CharacterClass.Warlock).ToString()),
            new SelectListItem(CharacterClass.Wizard.ToString(), ((int)CharacterClass.Wizard).ToString())

        };

        public Race Race { get; set; }

        public List<SelectListItem> Races { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(Race.Dwarf.ToString(), ((int)Race.Dwarf).ToString()),
            new SelectListItem(Race.Elf.ToString(), ((int)Race.Elf).ToString()),
            new SelectListItem(Race.Gnome.ToString(), ((int)Race.Gnome).ToString()),
            new SelectListItem(Race.HalfElf.ToString(), ((int)Race.HalfElf).ToString()),
            new SelectListItem(Race.Halfling.ToString(), ((int)Race.Halfling).ToString()),
            new SelectListItem(Race.HalfOrc.ToString(), ((int)Race.HalfOrc).ToString()),
            new SelectListItem(Race.Human.ToString(), ((int)Race.Human).ToString()),
            new SelectListItem(Race.Tiefling.ToString(), ((int)Race.Tiefling).ToString())

        };

        public Abilities Abilities { get; set; }

        public List<SelectListItem> Ability { get; set; } = new List<SelectListItem>
        {
            new SelectListItem(Abilities.AcidSplash.ToString(), ((int)Abilities.AcidSplash).ToString()),
            new SelectListItem(Abilities.ArcaneWeapon.ToString(), ((int)Abilities.ArcaneWeapon).ToString()),
            new SelectListItem(Abilities.AstralProjection.ToString(), ((int)Abilities.AstralProjection).ToString()),
            new SelectListItem(Abilities.Barkskin.ToString(), ((int)Abilities.Barkskin).ToString()),
            new SelectListItem(Abilities.Bless.ToString(), ((int)Abilities.Bless).ToString()),
            new SelectListItem(Abilities.BurningHands.ToString(), ((int)Abilities.BurningHands).ToString()),
            new SelectListItem(Abilities.CallLightning.ToString(), ((int)Abilities.CallLightning).ToString()),
            new SelectListItem(Abilities.ChaosBolt.ToString(), ((int)Abilities.ChaosBolt).ToString()),
            new SelectListItem(Abilities.ChainLightning.ToString(), ((int)Abilities.ChainLightning).ToString()),
            new SelectListItem(Abilities.ChillTouch.ToString(), ((int)Abilities.ChillTouch).ToString()),
            new SelectListItem(Abilities.CloudofDaggers.ToString(), ((int)Abilities.CloudofDaggers).ToString()),
            new SelectListItem(Abilities.CrownofStars.ToString(), ((int)Abilities.CrownofStars).ToString()),
            new SelectListItem(Abilities.CureWounds.ToString(), ((int)Abilities.CureWounds).ToString()),
            new SelectListItem(Abilities.DarkStar.ToString(), ((int)Abilities.DarkStar).ToString()),
            new SelectListItem(Abilities.DragonsBreath.ToString(), ((int)Abilities.DragonsBreath).ToString()),
            new SelectListItem(Abilities.DetectMagic.ToString(), ((int)Abilities.DetectMagic).ToString()),
            new SelectListItem(Abilities.DispelMagic.ToString(), ((int)Abilities.DispelMagic).ToString()),
            new SelectListItem(Abilities.Druidcraft.ToString(), ((int)Abilities.Druidcraft).ToString()),
            new SelectListItem(Abilities.DustDevil.ToString(), ((int)Abilities.DustDevil).ToString()),
            new SelectListItem(Abilities.EarthTremor.ToString(), ((int)Abilities.EarthTremor).ToString()),
            new SelectListItem(Abilities.Entangle.ToString(), ((int)Abilities.Entangle).ToString()),
            new SelectListItem(Abilities.FindTraps.ToString(), ((int)Abilities.FindTraps).ToString()),
            new SelectListItem(Abilities.Fireball.ToString(), ((int)Abilities.Fireball).ToString()),
            new SelectListItem(Abilities.Firebolt.ToString(), ((int)Abilities.Firebolt).ToString()),
            new SelectListItem(Abilities.Flamestrike.ToString(), ((int)Abilities.Flamestrike).ToString()),
            new SelectListItem(Abilities.Frostbite.ToString(), ((int)Abilities.Frostbite).ToString()),
            new SelectListItem(Abilities.FrostFingers.ToString(), ((int)Abilities.FrostFingers).ToString()),
            new SelectListItem(Abilities.HealingSpirit.ToString(), ((int)Abilities.HealingSpirit).ToString()),
            new SelectListItem(Abilities.HealingWord.ToString(), ((int)Abilities.HealingWord).ToString()),
            new SelectListItem(Abilities.IceKnife.ToString(), ((int)Abilities.IceKnife).ToString()),
            new SelectListItem(Abilities.IceStorm.ToString(), ((int)Abilities.IceStorm).ToString()),
            new SelectListItem(Abilities.Invisibility.ToString(), ((int)Abilities.Invisibility).ToString()),
            new SelectListItem(Abilities.LightningArrow.ToString(), ((int)Abilities.LightningArrow).ToString()),
            new SelectListItem(Abilities.LightningBolt.ToString(), ((int)Abilities.LightningBolt).ToString()),
            new SelectListItem(Abilities.MagicMissile.ToString(), ((int)Abilities.MagicMissile).ToString()),
            new SelectListItem(Abilities.MagicStone.ToString(), ((int)Abilities.MagicStone).ToString()),
            new SelectListItem(Abilities.Mending.ToString(), ((int)Abilities.Mending).ToString()),
            new SelectListItem(Abilities.MindSliver.ToString(), ((int)Abilities.MindSliver).ToString()),
            new SelectListItem(Abilities.MindSpike.ToString(), ((int)Abilities.MindSpike).ToString()),
            new SelectListItem(Abilities.Moonbeam.ToString(), ((int)Abilities.Moonbeam).ToString()),
            new SelectListItem(Abilities.PoisonSpray.ToString(), ((int)Abilities.PoisonSpray).ToString()),
            new SelectListItem(Abilities.RayofFrost.ToString(), ((int)Abilities.RayofFrost).ToString()),
            new SelectListItem(Abilities.SacredFlame.ToString(), ((int)Abilities.SacredFlame).ToString()),
            new SelectListItem(Abilities.ShadowBlade.ToString(), ((int)Abilities.ShadowBlade).ToString()),
            new SelectListItem(Abilities.ShapeWater.ToString(), ((int)Abilities.ShapeWater).ToString()),
            new SelectListItem(Abilities.ShieldofFaith.ToString(), ((int)Abilities.ShieldofFaith).ToString()),
            new SelectListItem(Abilities.Silence.ToString(), ((int)Abilities.Silence).ToString()),
            new SelectListItem(Abilities.StormSphere.ToString(), ((int)Abilities.StormSphere).ToString()),
            new SelectListItem(Abilities.SummonFey.ToString(), ((int)Abilities.SummonFey).ToString()),
            new SelectListItem(Abilities.SummonShadowspawn.ToString(), ((int)Abilities.SummonShadowspawn).ToString()),
            new SelectListItem(Abilities.SummonUndead.ToString(), ((int)Abilities.SummonUndead).ToString()),
            new SelectListItem(Abilities.Sunburst.ToString(), ((int)Abilities.Sunburst).ToString()),
            new SelectListItem(Abilities.ThornWhip.ToString(), ((int)Abilities.ThornWhip).ToString()),
            new SelectListItem(Abilities.TidalWave.ToString(), ((int)Abilities.TidalWave).ToString()),
            new SelectListItem(Abilities.TrueStrike.ToString(), ((int)Abilities.TrueStrike).ToString()),
            new SelectListItem(Abilities.VampiricTouch.ToString(), ((int)Abilities.VampiricTouch).ToString()),
            new SelectListItem(Abilities.WallofIce.ToString(), ((int)Abilities.WallofIce).ToString()),
            new SelectListItem(Abilities.WallofThorns.ToString(), ((int)Abilities.WallofThorns).ToString()),
            new SelectListItem(Abilities.WaterySphere.ToString(), ((int)Abilities.WaterySphere).ToString()),
            new SelectListItem(Abilities.WitchBolt.ToString(), ((int)Abilities.WitchBolt).ToString()),
            new SelectListItem(Abilities.WrathfulSmite.ToString(), ((int)Abilities.WrathfulSmite).ToString())
        };

    }
}
