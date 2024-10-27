using C_SharpProject_Id_1280689.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Repository
{
    public class AnimalRepository : IAnimalRepository
    {
        private List<Animal> animalList;
        public AnimalRepository()
        {
            animalList = new List<Animal>()
            {
                new Animal() {Id=1,Name="Poko",Age=2,Gender=Gender.Male,Type=AnimalType.Dog,
                    BehaviourWiseAnimal=BehaviourWiseAnimal.Domestic,
                    FoodwiseAnimal=FoodwiseAnimal.Omnivore},
                     new Animal() {Id=2,Name="Torry",Age=1,Gender=Gender.Female,Type=AnimalType.Horse,
                    BehaviourWiseAnimal=BehaviourWiseAnimal.Domestic,
                    FoodwiseAnimal=FoodwiseAnimal.Herbivore},
                          new Animal() {Id=3,Name="Gimme",Age=3,Gender=Gender.Male,Type=AnimalType.Cow,
                    BehaviourWiseAnimal=BehaviourWiseAnimal.Domestic,
                    FoodwiseAnimal=FoodwiseAnimal.Herbivore},
                               new Animal() {Id=4,Name="Poo",Age=5,Gender=Gender.Male,Type=AnimalType.Tiger,
                    BehaviourWiseAnimal=BehaviourWiseAnimal.Wild,
                    FoodwiseAnimal=FoodwiseAnimal.Carnivore}
            };
        }
        public Animal CreateAnimal(Animal animal)
        {
            Animal existingAnimal = ((from a in animalList orderby a.Id descending select a).
              Take(1)).Single() as Animal;
            animal.Id = existingAnimal.Id + 1;
            animalList.Add(animal);
            return animal;
        }

        public Animal DeleteAnimal(int id)
        {
            Animal deleteAnimal = GetAnimal(id);
            if (deleteAnimal != null)
            {
                animalList.Remove(deleteAnimal);
            }
            return deleteAnimal;
        }

        public IEnumerable<Animal> GetAllAnimals()
        {
            return from rows in animalList select rows;
        }

        public Animal GetAnimal(int id)
        {
            var animal = (from a in animalList where a.Id == id select a).Single();
            return animal;
        }

        public Animal UpdateAnimal(Animal updateAnimal)
        {
            Animal animal = GetAnimal(updateAnimal.Id);
            if (animal != null)
            {
                animal.Id = updateAnimal.Id;
                animal.Name = updateAnimal.Name;
                animal.Age = updateAnimal.Age;
                animal.Gender = updateAnimal.Gender;
                animal.Type = updateAnimal.Type;
                animal.BehaviourWiseAnimal = updateAnimal.BehaviourWiseAnimal;
                animal.FoodwiseAnimal = updateAnimal.FoodwiseAnimal;
                

            }
            return animal;
        }
    }
}
