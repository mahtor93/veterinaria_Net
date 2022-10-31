using System.Collections.Generic;
using System;
namespace certamen_2_mario_torneria.Models.ViewModels
{
    public class CreatePetViewModel
    {
        public List<string> CreateTypoPet { get; set; }
        
        public List<string> TyPet { get; set; }
        public DateTime dateToday { get; set; }
    }
}
