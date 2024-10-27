using C_SharpProject_Id_1280689.Entities;
using C_SharpProject_Id_1280689.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Factory
{
    public class HerbivoreAnimalFactory : BaseAnimalFactory
    {
        protected new Animal _anim;
        public HerbivoreAnimalFactory(Animal anim) : base(anim)
        {
            _anim = anim;
        }

        public override IAnimalManager Create()
        {
            HerbivoreAnimalManager manager = new HerbivoreAnimalManager();
            _anim.Ruminant=manager.GetRuminant();
            return manager;
        }
    }
}
