using dnd123.Models.Character;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.Data
{
    public class CharacterData
    {
        static private Dictionary<int, Character> Characters = new Dictionary<int, Character>();

        // GetAll
        public static IEnumerable<Character> GetAll()
        {
            return Characters.Values;
        }

        // Add
        public static void Add(Character newCharacter)
        {
            Characters.Add(newCharacter.Id, newCharacter);
        }

        // Remove
        public static void Remove(int id)
        {
            Characters.Remove(id);
        }

        // GetById
        public static Character GetById(int id)
        {
            return Characters[id];
        }
    }
}
