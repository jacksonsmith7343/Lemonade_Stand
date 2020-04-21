using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Recipe
    {
        public int amountOfLemons;
        public int amountOfSugarCubes;
        public int amountOfIceCubes;
        public double pricePerCup;

        public Recipe()
        {
            amountOfLemons = 4;
            amountOfSugarCubes = 20;
            amountOfIceCubes = 20;
            pricePerCup = .50;


        }

        public void CreateNewRecipe()
        {
            Console.WriteLine("What would you like to change to your recipe?\n1) Change lemons? \n2 Change sugar? \n3) Change ice?\n4) Change cups?");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                   // if ()
                    //{

                    //}
                    break;
                case "2":
                    
                    break;
                case "3":
                    
                    break;
                case "4":
                    
                    break;
                case "5":
                    
                default:
                    Console.WriteLine("Try again. Choose an item to adjust to your recipe or return to the main menu.");
                    break;

            }
        }

    }
}
