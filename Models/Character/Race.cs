using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.Models.Character
{
    public enum Race
    {
        Dwarf,
        Elf,
        Gnome,
        [Display(Name = "Half Elf")]
        HalfElf,
        Halfling,
        [Display(Name = "Half Orc")]
        HalfOrc,
        Human,
        Tiefling
    }
}
