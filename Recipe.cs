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

        public void CreateNewRecipe(Player player)
        {
            Console.WriteLine("What would you like to change to your recipe?\n1) Change lemons? \n2 Change sugar? \n3) Change ice?\n4) Change price per cup");
            string userInput = Console.ReadLine();
            
            switch (userInput)
            {
                case "1":
                    Console.WriteLine("How many lemons would you like in your recipe?");
                    userInput = Convert.ToInt32.(Console.ReadLine());
                    userInput = amountOfLemons;
                    
                    //userinput for how many lemons
                    //convert userinput into int, then set amount of lemons equal 
                    break;
                case "2":
                    Console.WriteLine("How many sugar cubes would you like in your recipe?");

                    break;
                case "3":
                    Console.WriteLine("How many ice cubes would you like in your recipe?");

                    break;
                case "4":
                    Console.WriteLine("What price would you like to set per cup?");

                    //convert to double
                    break;
                case "5":
                    
                default:
                    Console.WriteLine("Try again. Choose an item to adjust to your recipe or return to the main menu.");
                    break;

            }
        }

    }
}
