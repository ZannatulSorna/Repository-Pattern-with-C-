using C_SharpProject_Id_1280689.Entities;
using C_SharpProject_Id_1280689.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Factory
{
    public abstract class BaseAnimalFactory
    {
        protected Animal _anim;
        protected BaseAnimalFactory(Animal anim)
        {
            _anim = anim;
        }
        public abstract IAnimalManager Create();
        public Animal ApplyBehaviour()
        {
            IAnimalManager manager = this.Create();

            _anim.FoodType = manager.GetFoodType();
            _anim.AnimalNature = manager.GetAnimalNature();

            return _anim;

        }
    }
}
