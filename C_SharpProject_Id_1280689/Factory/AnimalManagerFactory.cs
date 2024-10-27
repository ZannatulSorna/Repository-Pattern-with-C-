using C_SharpProject_Id_1280689.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Factory
{
    public class AnimalManagerFactory
    {
        public BaseAnimalFactory CreateFactory(Animal anim)
        {
            BaseAnimalFactory returnValue = null;

            if (anim.FoodwiseAnimal == FoodwiseAnimal.Carnivore)
            {
                returnValue = new CarnivoreAnimalFactory(anim);
            }
            else if (anim.FoodwiseAnimal == FoodwiseAnimal.Herbivore)
            {
                returnValue = new HerbivoreAnimalFactory(anim);
            }
            else if (anim.FoodwiseAnimal == FoodwiseAnimal.Omnivore)
            {
                returnValue = new OmnivoreAnimalFactory(anim);
            }
            return returnValue;
        }
    }
}
