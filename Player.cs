using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand_3DayStarter
{
    class Player
    {
        // member variables (HAS A)
        public string name;
        public Inventory inventory;
        public Wallet wallet;
        public Recipe recipe;
        public Pitcher pitcher;
        

        

        // constructor (SPAWNER)
        public Player()
        {

            inventory = new Inventory();
            wallet = new Wallet();
            pitcher = new Pitcher();
            recipe = new Recipe();
            SetName();
        }

        // member methods (CAN DO)

       
    public void SetName()
    {
            Console.WriteLine("Plase eneter your name");
            name = Console.ReadLine();
    }
    



}
}
