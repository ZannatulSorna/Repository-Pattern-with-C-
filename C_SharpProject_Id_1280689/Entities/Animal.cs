using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689.Entities
{
    public class Animal
    {
        int id;
        string name;
        int age;
        Gender gender;
        AnimalType type;
        BehaviourWiseAnimal behaviourWiseAnimal;
        FoodwiseAnimal foodwiseAnimal;

        string foodType;
        string animalNature;
        string huntingTechnique;
        string ruminant;
        string opertunisticEater;

        public Animal()
        {

        }

        public Animal(int id, string name, int age, Gender gender, AnimalType type, BehaviourWiseAnimal behaviourWiseAnimal,
            FoodwiseAnimal foodwiseAnimal)
        {
            this.Id = id;
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
            this.Type = type;
            this.BehaviourWiseAnimal = behaviourWiseAnimal;
            this.FoodwiseAnimal = foodwiseAnimal;
        }

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public Gender Gender { get => gender; set => gender = value; }
        public AnimalType Type { get => type; set => type = value; }
        public BehaviourWiseAnimal BehaviourWiseAnimal { get => behaviourWiseAnimal; set => behaviourWiseAnimal = value; }
        public FoodwiseAnimal FoodwiseAnimal { get => foodwiseAnimal; set => foodwiseAnimal = value; }


        public string FoodType { get => foodType; set => foodType = value; }
        public string AnimalNature { get => animalNature; set => animalNature = value; }
        public string HuntingTechnique { get => huntingTechnique; set => huntingTechnique = value; }
        public string Ruminant { get => ruminant; set => ruminant = value; }
        public string OpertunisticEater { get => opertunisticEater; set => opertunisticEater = value; }
    }
}
