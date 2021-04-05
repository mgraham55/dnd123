using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.Models.Character
{
    public class CharacterAbility
    {
        public int CharacterId { get; set; }
        public Character Character { get; set; }

        public int AbilityId { get; set; }
        public Abilities Abilities { get; set; }

        public CharacterAbility()
        {
        }
    }
}
