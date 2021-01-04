using System;
using System.Collections.Generic;
using System.Text;
using static ConsoleAppshpping2.Item;

namespace ConsoleAppshpping2
{
    public class Menu1
    {
        //public static int Category { get; private set; }

        static void Main()
        {
           // int counter = 0;

            // Item i = new Item();
            Console.WriteLine("welcome to the restaurant");
            Console.WriteLine("show the menu");
            Console.WriteLine("enter your choice according to the category choose the category");
            Item i = new Item();
            programlist p = new programlist();
            String entrance = "yes";
            while (entrance.Equals("yes")) {
                int counter = 0;
                foreach (Item.Category t in Enum.GetValues(typeof(Item.Category)))
            {
                Console.WriteLine(counter++ + "   " + t);

            }
           // String entrance = "yes";
            


                Console.WriteLine("please enter your category");
                int result = 0;
                try
                {
                    
                    result = Convert.ToInt16(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("please enter valid choice");
                }
                switch (result)
                    {
                        case 0:
                            List<Item> Drinklist = programlist.Getdrinklist();
                            foreach (var r in Drinklist)
                            {
                                Console.WriteLine(r);
                            }
                            break;
                        case 1:
                            List<Item> snacklist = programlist.getsnacklist();
                            foreach (var r in snacklist)
                            {
                                Console.WriteLine(r);
                            }
                            break;
                        case 2:
                            List<Item> veglist = programlist.getveglist();
                            foreach (var r in veglist)
                            {
                                Console.WriteLine(r);
                            }
                            break;
                        case 3:
                            List<Item> nonveglist = programlist.getnonveglist();
                            foreach (var r in nonveglist)
                            {
                                Console.WriteLine(r);
                            }
                            break;
                        
                        default:
                            Console.WriteLine("please enter valid choice");
                            break;
                    }
                
                

            }
        }

    }
}



