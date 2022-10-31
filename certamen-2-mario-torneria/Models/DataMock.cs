using System.Collections.Generic;
using System;
using certamen_2_mario_torneria.Controllers;
namespace certamen_2_mario_torneria.Models
{
    public class DataMock
    {
        public static List<Pet> Pets = new List<Pet>()
        {
            new Pet()
            {
                IdPet="1312",
                NamePet = "Pantruca",
                BirthdayPet = new DateTime(2012,5,14,00,00,00),
                DateRegister = DateTime.Today,
                NameOwner ="Luis",
                PhoneOwner = 12131415,
                PetType=PetTypes.Cat,
            },
            new Pet()
            {
                IdPet="1313",
                NamePet = "Robin Batman",
                BirthdayPet = new DateTime(2017,9,4,00,00,00),
                DateRegister = DateTime.Today,
                NameOwner ="Pantruca",
                PhoneOwner = 13358415,
                PetType=PetTypes.Turtle,
            },
            new Pet()
            {
                IdPet="3644",
                NamePet = "Puntito",
                BirthdayPet = new DateTime(2021,4,12,00,00,00),
                DateRegister = DateTime.Today,
                NameOwner ="Luisa",
                PhoneOwner = 14578632,
                PetType=PetTypes.Cat,
            },
            new Pet()
            {
                IdPet="6644",
                NamePet = "Pandora",
                BirthdayPet = new DateTime(2021,4,12,00,00,00),
                DateRegister = DateTime.Today,
                NameOwner ="Angela",
                PhoneOwner = 65894512,
                PetType=PetTypes.Rat,
            },
            new Pet()
            {
                IdPet="9146",
                NamePet = "Melqui",
                BirthdayPet = new DateTime(2022,3,12,00,00,00),
                DateRegister = DateTime.Today,
                NameOwner ="Min",
                PhoneOwner = 13914512,
                PetType=PetTypes.Cat,
            },
            new Pet()
            {
                IdPet="6548",
                NamePet = "Chocha",
                BirthdayPet = new DateTime(2019,12,21,00,00,00),
                DateRegister = DateTime.Today,
                NameOwner ="Judi",
                PhoneOwner = 13123682,
                PetType=PetTypes.Dog,
            },
            new Pet()
            {
                IdPet="8844",
                NamePet = "Mimi",
                BirthdayPet = new DateTime(2022,4,12,00,00,00),
                DateRegister = DateTime.Today,
                NameOwner ="Min",
                PhoneOwner = 13395756,
                PetType=PetTypes.Cat,
            }
        };

    }
}
