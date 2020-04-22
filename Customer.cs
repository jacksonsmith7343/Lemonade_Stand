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


        //constructor (Spawner)
        public Customer()
        {

            names = new List<string>();
            names.Add("Robert");
            names.Add("Carol");
            names.Add("Justin");
        }

        //member methods (Can do)

        //Create a method called MakeBuyChoice(Weather weather, Recipe recipe) { ... }
        //try to come up with way using the wweather to generate a chance of buying for the customer


    }
}
