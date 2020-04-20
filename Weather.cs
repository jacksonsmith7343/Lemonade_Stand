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



        //Constructor (Spawner)

        public Weather()
        {
            weatherConditions = new List<string>();
            weatherConditions.Add("rain");
            weatherConditions.Add("sunny");
            weatherConditions.Add("overcast");
            weatherConditions.Add("partly cloudy");


            Random rnd = new Random();

            int i = rnd.Next(0, 3);

            condition = weatherConditions[i];

        }

        public int dailyTemperature()
        {
            Random rnd = new Random();

            int i = rnd.Next(60, 90);

            temperature = i;
        }

        
       
        


        //member methods (Can do)



    }
}
