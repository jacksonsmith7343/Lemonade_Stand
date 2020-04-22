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

        //constructor (Spawner)

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>() { new Customer(), new Customer(), new Customer(), new Customer(), new Customer() };
            rnd = new Random();
            GenerateCustomers();

        }

        public void GenerateCustomers()
        {
            int i = rnd.Next(6);
            for( i = 0; i < 6; i++)
            {
                customers.Add(new Customer());
            }

            
        }
        //Create a method that generates a random number
        //write a for loop that runs for the amount of the random number
        //on each iteration of the loop, inside of the loop, add a new Customer object to the list of customers


        //member methods (Can do)
        public void BeginDay(Player player)
        {
            
            //weather.DailyTemperature();
            //weather.DailyWeatherCondition();
            //loop over customers list
            //for each customer, call their MakeChoice method
            //if the method returns true, take a cup away from the pitcher and give the player the money from the customer based on the cost per cup from the recipe
            //if the method returns false, dont do anything and let the loop move to the next customer
        }

    }
}
