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
            Console.WriteLine("What would you like to change to your recipe?\n1) Change lemons? \n2 Change sugar? \n3) Change ice?\n4) Change price per cup");
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("How many lemons would you like in your recipe?");
                    amountOfLemons = Convert.ToInt32(Console.ReadLine());
                    break;
                case "2":
                    Console.WriteLine("How many sugar cubes would you like in your recipe?");
                    amountOfSugarCubes = Convert.ToInt32(Console.ReadLine());
                    break;
                case "3":
                    Console.WriteLine("How many ice cubes would you like in your recipe?");
                    amountOfIceCubes = Convert.ToInt32(Console.ReadLine());
                    break;
                case "4":
                    Console.WriteLine("What price would you like to set per cup?");
                    pricePerCup = Convert.ToDouble(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("Try again. Choose an item to adjust to your recipe or return to the main menu.");
                    break;

            }
        }

    }
}
