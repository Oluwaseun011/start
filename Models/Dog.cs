using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start.Enums;

namespace start.Models
{
    public class Dog
    {
        public int Id;
        public string TagNumber;
        public string Name;
        public string CategoryName;
        public decimal Price;
        public double Weight;
        public double Height;
        public int Age;
        public string Color;
        public Gender Gender;

        public Dog(int id,string tag, string name,string categoryName,decimal price, double weight, double height, int age, string color, Gender gender)
        {
            Id = id;
            TagNumber = tag;
            Name = name;
            CategoryName = categoryName;
            Price = price;
            Weight = weight;
            Height = height;
            Age = age;
            Color = color;
            Gender = gender;
        }
    }
}