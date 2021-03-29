using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.Models.Character
{
    public class Race
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        public string IconUrl { get; set; }
    }
}
