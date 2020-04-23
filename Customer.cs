using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Customer
    {
        //member variables (Has a)

        private List<string> names;
        public string name;
        public Random rnd;
        public bool boughtLemonade;
        

        //constructor (Spawner)
        public Customer()
        {
            rnd = new Random();

        }

        //member methods (Can do)

        public bool MakeBuyChoice(Weather weather, Recipe recipe)
        {
            
            int i = 0;
            if (weather.temperature >= 80 && recipe.pricePerCup <= .5)
            {
                 i = rnd.Next(4, 10);
            }
            if (weather.temperature <= 79 && recipe.pricePerCup >= .5)
            {
                 i = rnd.Next(0, 10);
            }
            if (i >= 5)
            {
                return true;
            }
            else
            {
                return false;
            }
        }



    }
}
