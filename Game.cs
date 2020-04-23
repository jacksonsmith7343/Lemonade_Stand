using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Game
    {
        //member variables (Has a)
        private Player player;
        private List<Day> days;
        public Store store;
        
        

        //constructor (Spawner)
        public Game()
        {
            player = new Player();
            store = new Store();
            days = new List<Day>() { new Day(), new Day(), new Day(), new Day(), new Day(), new Day(), new Day() };
        }


        //member methods (Can do)
        public void RunGame()
        {
            for (int i = 0; i < days.Count; i++)
            {
                Console.WriteLine("Current Day: " + i);
                Menu(days[i]);

            }
        }


        public void Menu(Day day)
        {
            Console.WriteLine("What would you like to do? \n1) Go to Store \n2) Set Recipe\n3) Check Inventory\n4) Start Day");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    store.StoreMenu(player);
                    break;
                case "2":
                    player.recipe.CreateNewRecipe();
                    break;
                case "3":
                    player.inventory.CheckInventory();
                    break;
                case "4":
                    day.SimulateDay(player); 
                    break;
                default:
                    Menu(day);
                    break;
            }
        }
        public void DailyDisplayProfit(Player player) //get called once the SimulateGame completes?
        {
            for (int i = 0; i <= days.Count; i++)
            {
               Console.WriteLine(MakeBuyChoice.true * recipe.pricePerCup); 
            }
              
        }
        public void DisplayLoss()
        {

        }


    }
}
