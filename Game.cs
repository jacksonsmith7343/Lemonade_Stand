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
        private int currentDay;
        public Store store;

        //constructor (Spawner)
        public Game()
        {
            player = new Player();
            days = new List<Day>();

        }



        //member methods (Can do)
        public void RunGame()
        {
            Menu();
           
           
        }

        public void Menu()
        {
            Console.WriteLine("What would you like to do? \n1) Store\n2)Set Recipe\n3) Check Inventory\n4) Start Day");
            string userInput = Console.ReadLine();
            switch (userInput)
            {
                case "1":
                    Store store = new Store();
                    store.StoreMenu(player);
                    break;
                case "2":
                    //Recipe();
                    break;
                case "3":
                    //Inventory();
                    break;
                case "4":
                    //Day();
                    break;
                default:
                    Menu();
                    break;
                
               
            }
        }



    }
}
