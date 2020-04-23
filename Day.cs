using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Day
    {
        //member variables (Has a)
        public Weather weather;
        public List<Customer> customers;
        private Random rnd;
        double dailyProfits;

        //constructor (Spawner)

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>() { new Customer(), new Customer(), new Customer(), new Customer(), new Customer()};
            rnd = new Random();
            GenerateCustomers();
            dailyProfits = 0;

        }

        public void GenerateCustomers()
        {
            int i = rnd.Next(6);
            for( i = 0; i < 6; i++)
            {
                customers.Add(new Customer());
            }

            
        }
        
        //member methods (Can do)
        public void SimulateDay(Player player)
        {
            
            for (int i = 0; i <= customers.Count; i++)
            {
                bool decision = customers[i].MakeBuyChoice(weather, player.recipe);
                if (decision == true)
                {
                    player.pitcher.cupsLeftInPitcher -= 1;
                    player.wallet.Money += player.recipe.pricePerCup;
                    dailyProfits += player.recipe.pricePerCup;
                }
                else
                {
                    
                }
              

            }
            
            

            //loop over customers list
            //for each customer, call their MakeChoice method
            //if the method returns true, take a cup away from the pitcher and give the player the money from the customer based on the cost per cup from the recipe
            //if the method returns false, dont do anything and let the loop move to the next customer
        }

    }
}
