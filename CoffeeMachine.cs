using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQlekcija
{
    public class CoffeeMachine
    {
        private List<string> _drinks = new List<string>();
        public int Coins { get; set; }
        
        public CoffeeMachine()
        {
            _drinks = new List<string>();
        }

        public CoffeeMachine(List<string> listOfDrinks)
        {
            _drinks = listOfDrinks;
        }

        public bool DrinkHave(string drinkName)
        {
            if (_drinks.Contains(drinkName))
            {
                return true;
            }
            else return false;
        }

        public void InsertCoins(int coins)
        {
            if (coins < 0)
                coins = 0;

            Coins = Coins + coins;
        }

        public int CoinsInfo()
        {
            return Coins;
        }

        public string DrinkGet(int Coins, int price)
        {
            if (Coins >= price)
                return "Enjoy your drink!";
            else
                return "Insert more coins";
        }

        public string DrinkChange(int Coins, int price)
        {
            if (Coins == price)
                return "Precise number of coins inserted";
            else if (Coins > price && Coins - price == 1)
                return "Giving back 1 coin";
            else if (Coins > price && Coins - price > 1)
                return "Giving back " + (Coins - price) + " coins";
            else
                return "Insert more coins";
        }
    }
}
