using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start.Enums;
using start.Models;

namespace start.Managers
{
    public class DogLogic
    {
        public static List<Dog> DogTable = new List<Dog>();

        private string GenTagNumber(string categoryName)
        {
            return $"DC/{categoryName.Substring(0,3).ToUpper()}/{new Random().Next(100,999)}";
        }
        public Dog CreateDog(string name,string categoryName,decimal price, double weight, double height, int age, string color, Gender gender)
        {
            var id = DogTable.Count+1;
            var tag = GenTagNumber(categoryName);
            Dog dog = new Dog(id,tag,name,categoryName,price,weight,height,age,color,gender);
            DogTable.Add(dog);
            return dog;
        }

        public Dog UpdateDog(string tag, string name,decimal price, double weight, double height, string color, Gender gender)
        {
            var dog = GetDog(tag);
            if(dog == null) return null;
            dog.Name = name;
            dog.Price = price;
            dog.Weight = weight;
            dog.Height = height;
            dog.Color = color;
            dog.Gender = gender;
            return dog;
        }

        public Dog GetDog(string tag)
        {
            var dog = DogTable.Find(item => item.TagNumber == tag);
            return dog;
        }

        public List<Dog> GetDogs()
        {
            return DogTable;
        }

        public bool DeleteDog(string tag)
        {
            var dog = GetDog(tag);
            if(dog == null) return false;
            DogTable.Remove(dog);
            return true;
        }
    }
}