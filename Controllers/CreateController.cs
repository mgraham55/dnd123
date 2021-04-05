using dnd123.Data;
using dnd123.Models.Character;
using dnd123.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.Controllers
{
    public class CreateController : Controller
    {
        private CharacterDbContext context;

        public CreateController(CharacterDbContext dbContext)
        {
            context = dbContext;
        }

        public IActionResult Index()
        {
            List<Character> Characters = context.Characters.ToList();

            return View(Characters);
        }

        public IActionResult Add()
        {
            AddCharacterViewModel addCharacterViewModel = new AddCharacterViewModel();

            return View(addCharacterViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCharacterViewModel addCharacterViewModel, string[] selectedSkills)
        {
            if (ModelState.IsValid)
            {
                Character newCharacter = new Character
                {
                    Name = addCharacterViewModel.Name,
                    Bio = addCharacterViewModel.Bio,
                    CharacterClass = addCharacterViewModel.CharacterClass,
                    Race = addCharacterViewModel.Race,
                };

                for (int i = 0; i < selectedSkills.Length; i++)
                {
                    CharacterAbility ability = new CharacterAbility
                    {
                        CharacterId = newCharacter.Id,
                        Character = newCharacter,
                        AbilityId = Int32.Parse(selectedSkills[i]),
                    };
                    context.CharacterAbility.Add(ability);
                }

                context.Characters.Add(newCharacter);
                context.SaveChanges();

                return Redirect("/Create");
            }

            return View(addCharacterViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.characters = context.Characters.ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] characterIds)
        {
            foreach (int characterId in characterIds)
            {
                Character theCharacter = context.Characters.Find(characterId);
                context.Characters.Remove(theCharacter);
            }
            context.SaveChanges();

            return Redirect("/Create");
        }
    }
} 
