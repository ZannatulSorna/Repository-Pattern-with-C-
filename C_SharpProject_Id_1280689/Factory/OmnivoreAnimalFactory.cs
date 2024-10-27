using C_SharpProject_Id_1280689.Entities;
using C_SharpProject_Id_1280689.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Factory
{
    public class OmnivoreAnimalFactory : BaseAnimalFactory
    {
        protected new Animal _anim;
        public OmnivoreAnimalFactory(Animal anim) : base(anim)
        {
            _anim = anim;
        }

        public override IAnimalManager Create()
        {
            OmnivoreAnimalManager manager = new OmnivoreAnimalManager();
            _anim.OpertunisticEater = manager.GetOpertunisticEater();
            return manager;
        }
    }
}
