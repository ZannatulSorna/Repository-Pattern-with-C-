﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Manager
{
    public class OmnivoreAnimalManager : IAnimalManager
    {
        public string GetAnimalNature()
        {
            return "Harmfull";
        }

        public string GetFoodType()
        {
            return "Everything";
        }
        public string GetOpertunisticEater()
        {
            return "Cannibal";
        }

    }
}