using C_SharpProject_Id_1280689.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Repository
{
    public interface IAnimalRepository
    {
        IEnumerable<Animal> GetAllAnimals();
        Animal GetAnimal(int id);
        Animal CreateAnimal(Animal animal);
        Animal UpdateAnimal(Animal animal);
        Animal DeleteAnimal(int id);
    }
}
