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

        public void Menue()
        {

        }



    }
}
