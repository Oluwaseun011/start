using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace start.Models
{
    public class Category
    {
        public int Id;
        public string Name;
        public string Description;

        public Category(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}