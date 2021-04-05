using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dnd123.Models.Character
{
    public class Character
    {
        public string Name { get; set; }

        public string Bio { get; set; }

        public Race Race { get; set; }

        public CharacterClass CharacterClass { get; set; }

        public List<CharacterAbility> CharacterAbility { get; set; }
        
        public int Id { get; set; }

        public Character(string name, string bio)
        {
            Name = name;
            Bio = bio;
        }

        public Character()
        {
        }

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            return obj is Character @character &&
                   Id == @character.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }


}
