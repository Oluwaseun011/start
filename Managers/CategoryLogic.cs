using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using start.Models;

namespace start.Managers
{
    public class CategoryLogic
    {
        public static List<Category> CategoryTable = new List<Category>();

        private bool CategoryExists(string name)
        {
            foreach (var item in CategoryTable)
            {
                if (item.Name.ToUpper() == name.ToUpper())
                {
                    return true;
                }
            }
            return false;
        }
        public Category CreateCategory(string name, string description)
        {
            var exists = CategoryExists(name);
            if (exists)
            {
                return null;
            }

            Category category = new Category(CategoryTable.Count + 1, name, description);
            CategoryTable.Add(category);
            return category;
        }

        public Category UpdateCategory(string name, string description)
        {
            var category = GetCategory(name);
            if(category == null)
            {
                return null;
            }

            category.Description = description;
            return category;
        }

        public Category GetCategory(string name)
        {
            foreach (var item in CategoryTable)
            {
                if (item.Name.ToUpper() == name.ToUpper())
                {
                    return item;
                }
            }
            return null;
        }

        public List<Category> GetCategories()
        {
            return CategoryTable;
        }

        public bool DeleteCategory(string name)
        {
            var category = GetCategory(name);
            if(category == null)
            {
                return false;
            }

            CategoryTable.Remove(category);
            return true;
        }
    }
}