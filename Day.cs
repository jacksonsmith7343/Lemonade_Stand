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


        //constructor (Spawner)

        public Day()
        {
            weather = new Weather();
            customers = new List<Customer>();

        }

        //member methods (Can do)
        public void BeginDay()
        {
            weather.DailyTemperature();
            weather.DailyWeatherCondition();
        }

    }
}
