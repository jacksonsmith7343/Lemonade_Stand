using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Weather
    {
        //member variables (Has A)

        
        private List <string> weatherConditions;
        public int temperature;
        public string condition;
        private Random rnd;


        //Constructor (Spawner)

        public Weather()
        {
            rnd = new Random();
            weatherConditions = new List<string>() { "rain", "sunny", "overcast", "partly cloudy" };
            DailyWeatherCondition();
            DailyTemperature();

        }

        public void DailyTemperature()
        {
            temperature = rnd.Next(60, 90);
            //TODO finish switch cases
            switch (condition)
            {
                case "rain":
                    temperature = rnd.Next(40, 60);
                    break;
                case "sunny":
                    temperature = rnd.Next(60, 100);
                    break;
                case "overcast":
                    temperature = rnd.Next(60, 80);
                    break;
                case "partly coudy":
                    temperature = rnd.Next(40, 60);
                    break;
               



            }
        }

       

        //member methods (Can do)

        public void DailyWeatherCondition()
        {
            int i = rnd.Next(0, 4);

            condition = weatherConditions[i];
        }


    }
}
