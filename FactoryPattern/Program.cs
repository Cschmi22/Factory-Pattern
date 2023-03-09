using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;

namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What do you want for dinner? Mahi Mahi, Chicken, or Short Ribs? ");
            string userInput = Console.ReadLine();

            Kitchen kitchen = new Kitchen();
            IDinner myDinner = kitchen.GetFood(userInput);
            myDinner.Cook();

        }
        
    }
}
