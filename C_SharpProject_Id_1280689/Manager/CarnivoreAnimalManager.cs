using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Manager
{
    public class CarnivoreAnimalManager : IAnimalManager
    {
        public string GetAnimalNature()
        {
            return "Fierce";
        }

        public string GetFoodType()
        {
            return "Meat";
        }
        public string GetHuntingTechnique()
        {
            return "Hunt prey";
        }
    }
}
