using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using certamen_2_mario_torneria.Models;
using certamen_2_mario_torneria.Models.ViewModels;
using System.Linq;
using System;

namespace certamen_2_mario_torneria.Controllers
{
    public class PetController : Controller
    {
        public IActionResult Records()
        {
            PetViewModel viewModel = new();
            viewModel.Pets = DataMock.Pets;
            viewModel.TypoPet = TypoPet.PetTypeListed.ToList();
            ViewData["titulo"] = "Fichas de Mascotas";
            return View(viewModel);
        }

        public IActionResult CreateRecord()
        {
            CreatePetViewModel model = new();


            model.TyPet = new List<string>() { PetTypes.Dog, PetTypes.Cat, PetTypes.Bunny, PetTypes.Turtle, PetTypes.Rat, PetTypes.Other };
            model.CreateTypoPet = TypoPet.PetTypeListed.ToList();




            ViewData["ID"] = IdGen();
            ViewData["date"] = DateTime.Today.ToString("dd/MM/yyyy");
            ViewData["dateMax"] = DateTime.Today.ToString("yyyy/MM/dd");
            ViewData["titulo"] = "Agregar Mascota";
            return View(model);
        }

        public IActionResult FindPet(string petTypeFind, string petNameFind)
        {
            PetViewModel viewModel = new();

            viewModel.Pets = DataMock.Pets.Where(f => f.PetType.Equals(petTypeFind) || f.NamePet.Equals(petNameFind)).ToList();
            viewModel.TypoPet = TypoPet.PetTypeListed.ToList();
            ViewData["pettype"] = TypoPet.PetTypeListed;
            return View("Records", viewModel);
        }

        public IActionResult SavePet(Pet pet)
        {
            DataMock.Pets.Add(pet);
            return RedirectToAction(nameof(Records));
        }


        public int IdGen()
        {
            Random IdNumber = new();
            List<int> IDNUM_LIST = new();
            IDNUM_LIST.Add(1312); //estas variables corresponden a los ID utilizados en el data mock
            IDNUM_LIST.Add(1313);
            IDNUM_LIST.Add(3644);
            IDNUM_LIST.Add(6644);
            IDNUM_LIST.Add(9146);
            IDNUM_LIST.Add(6548);
            IDNUM_LIST.Add(8844);
            bool cycl=true;
            do
            {
                int _rand_ = IdNumber.Next(1000, 9999);
                for (int i = 0; i < IDNUM_LIST.Count; i++)
                {
                    if (_rand_ != IDNUM_LIST[i])
                    {
                        IDNUM_LIST.Add(_rand_);
                        cycl = false;
                        return _rand_;
                    }
                }
            } while (cycl == true);

            return 0;

        }

    }
}
