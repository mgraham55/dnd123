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

    }
}
