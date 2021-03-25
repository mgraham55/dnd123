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
        public IActionResult Index()
        {
            List<Character> Characters = new List<Character>(CharacterData.GetAll());

            return View(Characters);
        }

        public IActionResult Add()
        {
            AddCharacterViewModel addCharacterViewModel = new AddCharacterViewModel();

            return View(addCharacterViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddCharacterViewModel addCharacterViewModel)
        {
            if (ModelState.IsValid)
            {
                Character newCharacter = new Character
                {
                    Name = addCharacterViewModel.Name,
                    Bio = addCharacterViewModel.Bio,
                    CharacterClass = addCharacterViewModel.CharacterClass,
                    Race = addCharacterViewModel.Race
                };

                CharacterData.Add(newCharacter);

                return Redirect("/Create");
            }

            return View(addCharacterViewModel);
        }

        public IActionResult Delete()
        {
            ViewBag.characters = CharacterData.GetAll();

            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] characterIds)
        {
            foreach (int characterId in characterIds)
            {
                CharacterData.Remove(characterId);
            }

            return Redirect("/Create");
        }
    }
} 
