using System;
using System.Collections.Generic;

namespace ConsoleAppshpping2
{
    public   class programlist
    {
        
        public static List<Item> Getdrinklist()
        {
            List<Item> drinking = new List<Item>()

            {
                new Item { Name = "papaya", Price = 124 },
                new Item { Name = "watermeleon", Price = 128 },
                new Item { Name = "pineapple", Price = 100 },
                new Item { Name = "pineapple11", Price = 55 },
                new Item { Name = "pineapplesgf", Price = 65 },
                new Item { Name = "pineapplesgfyuu", Price = 30 },
            };
            return drinking;
        }
        public static List<Item> getsnacklist()
        {
            List<Item> snacking = new List<Item>()






            {
                new Item { Name = "chips", Price = 120 },
                new Item { Name = "samosa", Price = 121 },
                new Item { Name = "sandwitch", Price = 100 },
                new Item { Name = "biscuits", Price = 50 },
                new Item { Name = "samosa12", Price = 64 },
                new Item { Name = "biscuits12", Price = 41 },
            };
            return snacking;
        }

        public static List<Item> getveglist()
        {
            List<Item> vegi = new List<Item>()
            {
                new Item { Name = "alugadda", Price = 125 },
                new Item { Name = "tamota", Price = 137 },
                new Item { Name = "brinjal", Price = 100 },
                new Item { Name = "milmaker", Price = 52 },
                new Item { Name = "panner", Price = 63 },
                new Item { Name = "panner12", Price = 43 },
            };
            return vegi;




        }
        public static List<Item> getnonveglist()
        {
            List<Item> nonvegi = new List<Item>()

            {
                new Item { Name = "chicken", Price = 240 },
                new Item { Name = "mutton", Price = 300
                },
                new Item { Name = "fish", Price = 700 },
                new Item { Name = "chicken65", Price = 600 },
                new Item { Name = "mutton1", Price = 450 },
                new Item { Name = "mutton3", Price = 500 },
            };
            return nonvegi;




        }

    }
}


