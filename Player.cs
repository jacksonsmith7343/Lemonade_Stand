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

        //void PurchaseItems();
        //{
        //    SellSugarCubes();
        //    SellLemons();
        //    SellIceCubes();
        //    SellCups();
        //}

    public void SetName()
    {
            Console.WriteLine("Plase eneter your name");
            name = Console.ReadLine();
    }
    //player should be able to go to the store and purchase items
    //player will use money in their wallet to purchase items



}
}
