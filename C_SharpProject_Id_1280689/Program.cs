using C_SharpProject_Id_1280689.Entities;
using C_SharpProject_Id_1280689.Factory;
using C_SharpProject_Id_1280689.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SharpProject_Id_1280689
{
   
    internal class Program
    {
        public static AnimalRepository repo = new AnimalRepository();
        static void Main(string[] args)
        {
            try
            {
                DoTask();
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
            finally { Console.ReadLine(); }
        }

        private static void DoTask()
        {
            Console.WriteLine("\t\t\t\tAnimal Information\r");
            Console.WriteLine("\t\t\t\t-------------------\n");
            Console.WriteLine("\t\tHow many operation would you like to perform?\r");
            Console.WriteLine();
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            int operationNumber = 0;
            if (count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                 
                    Console.WriteLine("\t\t\t\tSelect Operation\n");
                   
                    Console.WriteLine("\t\t\t\tHint: \n\t\t\t\tSelect -1\n\t\t\t\tCreate -2\n\t\t\t\tUpdate -3\n\t\t\t\tDelete -4\n");
                  
                    operationNumber = Convert.ToInt16(Console.ReadLine());
                    switch (operationNumber)
                    {
                        case 1:
                            ShowAllAnimal(null);
                            Console.WriteLine();
                            break;

                        case 2:
                            CreateNewAnimal();
                            Console.WriteLine();
                            break;

                        case 3:
                            UpdateAnimal();
                            Console.WriteLine();
                            break;

                        case 4:
                            DeleteAnimal();
                            Console.WriteLine();
                            break;
                        default:
                            Console.WriteLine("Invalid operation");
                            break;
                    }
                }
            }

        }

        private static void DeleteAnimal()
        {
            Console.WriteLine("Enter ID of the animal that you want to delete");
            int deleteId=Convert.ToInt32(Console.ReadLine());
            Animal deleteAnimal=new Animal();
            deleteAnimal.Id = deleteId;
            deleteAnimal = repo.DeleteAnimal(deleteId);
            Console.WriteLine("\t\t\t\t*Animal deleted successfully");
            Console.WriteLine();
            ShowAllAnimal(deleteAnimal);

        }

        private static void UpdateAnimal()
        {
            Console.WriteLine("Enter ID");
            int iD=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\t\t\tEnter Name");
            string name = Console.ReadLine();
            Console.WriteLine("\t\t\tEnter Age ");
            int age = Convert.ToInt32(Console.ReadLine());
           

        EnterType:
            Console.WriteLine("Enter FoodWise Type *Hint: Omnivore-1,Herbivore-2,Carnivore-3");
            string typeRead = Console.ReadLine();
            FoodwiseAnimal food;
            try
            {
                food = (FoodwiseAnimal)Enum.Parse(typeof(FoodwiseAnimal), typeRead);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterType;
            }

        EnterAnimalType:
            Console.WriteLine("Enter Animal Type *Hint: Dog- 1,Horse- 2,Tiger- 3,Human- 4,Cow- 5,Lion- 6");
            string type = Console.ReadLine();
            AnimalType anilType;
            try
            {
                anilType = (AnimalType)Enum.Parse(typeof(AnimalType), type);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterAnimalType;
            }

        EnterBehaviour:
            Console.WriteLine("Enter Animal Behaviour *Hint: Others- 1,Wild- 2,Domestic- 3");
            string behaviour = Console.ReadLine();
            BehaviourWiseAnimal anibehaviour;
            try
            {
                anibehaviour = (BehaviourWiseAnimal)Enum.Parse(typeof(BehaviourWiseAnimal), behaviour);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterBehaviour;
            }

        EnterGender:
            Console.WriteLine("Enter Gender  *Hint: Others- 1,Male- 2,Female- 3"); ;
            string genderType = Console.ReadLine();
            Gender anigender;
            try
            {
                anigender = (Gender)Enum.Parse(typeof(Gender), genderType);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterGender;
            }

            Animal updateAnimal = new Animal();
            updateAnimal.Id = iD;
            updateAnimal.Name = name;
            updateAnimal.Age = age;
            updateAnimal.Gender = anigender;
            updateAnimal.Type = anilType;
            updateAnimal.BehaviourWiseAnimal = anibehaviour;


            updateAnimal.FoodwiseAnimal = food;
            updateAnimal = repo.UpdateAnimal(updateAnimal);

            Console.WriteLine("\t\t\t\t*Animal updated successfully");
            Console.WriteLine();
            ShowAllAnimal(updateAnimal);
        }



        private static void CreateNewAnimal()
        {
            Console.WriteLine("\t\t\tEnter Name");
            string name=Console.ReadLine();
            Console.WriteLine("\t\t\tEnter Age ");
            int age = Convert.ToInt32(Console.ReadLine());


        EnterType:
            Console.WriteLine("Enter FoodWise Type *Hint: Omnivore-1,Herbivore-2,Carnivore-3");
            string typeRead = Console.ReadLine();
            FoodwiseAnimal food;
            try
            {
                food = (FoodwiseAnimal)Enum.Parse(typeof(FoodwiseAnimal),typeRead);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterType;
            }

        EnterAnimalType:
            Console.WriteLine("Enter Animal Type *Hint: Dog- 1,Horse- 2,Tiger- 3,Human- 4,Cow- 5,Lion- 6");
            string type = Console.ReadLine();
            AnimalType anilType;
            try
            {
                anilType = (AnimalType)Enum.Parse(typeof(AnimalType), type);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterAnimalType;
            }
        EnterBehaviour:
            Console.WriteLine("Enter Animal Behaviour *Hint: Others- 1,Wild- 2,Domestic- 3");
            string behaviour = Console.ReadLine();
            BehaviourWiseAnimal anibehaviour;
            try
            {
                anibehaviour = (BehaviourWiseAnimal)Enum.Parse(typeof(BehaviourWiseAnimal), behaviour);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterBehaviour;
            }

        EnterGender:
            Console.WriteLine("Enter Gender  *Hint: Others- 1,Male- 2,Female- 3"); ;
            string genderType = Console.ReadLine();
            Gender anigender;
            try
            {
                anigender = (Gender)Enum.Parse(typeof(Gender), genderType);
            }
            catch
            {
                Console.WriteLine("Invalid type!! Try Again");
                goto EnterGender;
            }

            Animal animal = new Animal(1, name, age, anigender, anilType, anibehaviour, food);

            BaseAnimalFactory animFactory = new AnimalManagerFactory().CreateFactory(animal);
            animFactory.ApplyBehaviour();
            repo.CreateAnimal(animal);
            Console.WriteLine("\t\t\t\t*Animal added successfully");
            Console.WriteLine();
            ShowAllAnimal(animal);
        }
        private static void ShowAllAnimal(Animal animal)
        {

            IEnumerable<Animal> animals = repo.GetAllAnimals();
            Console.WriteLine(string.Format("| {0,2}| {1,10}| {2,2}| {3,6}| {4,6}| {5,9}| {6,9}| {7,10}| {8,10}| {9,10}| {10,10}| {11,12}|", "ID", "Name",
                "Age", "Gender", "Type", "Behaviour", "Feeding ", "Food", "Nature", "Hunting", "Ruminant", "Opertunistic"));
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            if (animal == null)
            {
                foreach (Animal item in animals)
                {
                    Console.WriteLine(string.Format("| {0,2}| {1,10}| {2,2}| {3,6}| {4,6}| {5,10}| {6,9}| {7,10}| {8,10}| {9,10}| {10,10}| {11,12}|",
                   item.Id, item.Name, item.Age, item.Gender, item.Type, item.BehaviourWiseAnimal, item.FoodwiseAnimal, item.FoodType,
                   item.AnimalNature, item.HuntingTechnique, item.Ruminant, item.OpertunisticEater));


                }

            }
            else
            {
                Console.WriteLine(string.Format("| {0,2}| {1,10}| {2,2}| {3,6}| {4,6}| {5,10}| {6,9}| {7,10}| {8,10}| {9,10}| {10,10}| {11,12}|",
                   animal.Id, animal.Name, animal.Age, animal.Gender, animal.Type, animal.BehaviourWiseAnimal, animal.FoodwiseAnimal, animal.FoodType,
                   animal.AnimalNature, animal.HuntingTechnique, animal.Ruminant, animal.OpertunisticEater));

            }
        }













    }
}
