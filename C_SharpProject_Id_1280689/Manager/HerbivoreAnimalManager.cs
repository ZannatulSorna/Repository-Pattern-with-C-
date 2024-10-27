using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Manager
{
    public class HerbivoreAnimalManager : IAnimalManager
    {
        public string GetAnimalNature()
        {
            return "Harmless";
        }

        public string GetFoodType()
        {
            return "Vegetable";
        }
        public string GetRuminant()
        {
            return "ruminent";
        }
    }
}
