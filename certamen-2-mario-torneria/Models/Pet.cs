using System;
using System.Collections.Generic;

namespace certamen_2_mario_torneria.Models
{
    public class Pet
    {
        public string IdPet { get; set; }
        public string NamePet { get; set; }
        public DateTime BirthdayPet{ get; set; }
        public DateTime DateRegister{get; set;}
        public string NameOwner { get; set; }
        public int PhoneOwner { get; set; }
        public string PetType { get; set; }

    }


    public static class PetTypes
    {
        public const string Dog = "Perro", Cat = "Gato", Bunny = "Conejo", Turtle = "Tortuga", Rat = "Hámster", Other = "Otros";
    }
    public static class TypoPet
    {
        public static string[] PetTypeListed = { "Perro", "Gato", "Conejo", "Tortuga", "Hámster", "Otros" };
    }

}
