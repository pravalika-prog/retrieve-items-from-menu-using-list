using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppshpping2
{
    public class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public Category category { get; set; }
        //public decimal Price { get; set; }
        public Item(string pName, Category pCategory, int lprice)
        {

            Name = pName;
            category = pCategory;
            Price = lprice;
        }

        public Item()
        {


        }

        public enum Category
        {
            Drinks,
            Snacks,
            veg,
            nonveg,
        }
        public override string ToString()
        {
            return Name + " : "  + Price;


        }
    }
}
        
         

