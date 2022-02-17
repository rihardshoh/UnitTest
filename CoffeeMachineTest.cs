using LINQlekcija;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace TestProject2
{
    [TestClass]
    public class CoffeeMachineTest
    {
        [TestMethod]
        public void DrinkIsInTheList() // checks if drink is in the list, it is
        {
            CoffeeMachine coffee = new CoffeeMachine(new List<string> { "Espresso", "Latte", "Cappuccion" });
            bool result = coffee.DrinkHave("Espresso");
            bool expectedResult = true;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void DrinkIsNotInTheList() // checks if drink is in the list, it is not
        {
            CoffeeMachine coffee = new CoffeeMachine(new List<string> { "Espresso", "Latte", "Cappuccion" });
            bool result = coffee.DrinkHave("Americano");
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void CoinsInserted1() // checks how many coins are inserted, 1
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(1);

            int expectedResult = 1;
            Assert.AreEqual(expectedResult, coffeeMachine.CoinsInfo());
        }

        [TestMethod]
        public void CoinsInserted2() // checks how many coins are inserted, 2
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(-1);
            coffeeMachine.InsertCoins(2);

            int expectedResult = 2;
            Assert.AreEqual(expectedResult, coffeeMachine.CoinsInfo());
        }

        [TestMethod]
        public void CoinsEnoughInserted() // check if enough coins inserted to get the drink, enough
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(5);
            int price = 5;

            string expectedResult = "Enjoy your drink!";
            Assert.AreEqual(expectedResult, coffeeMachine.DrinkGet(coffeeMachine.CoinsInfo(),price));
        }

        [TestMethod]
        public void CoinsNotEnoughInserted() // check if enough coins inserted to get the drink, not enough
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(0);
            int price = 5;

            string expectedResult = "Insert more coins";
            Assert.AreEqual(expectedResult, coffeeMachine.DrinkGet(coffeeMachine.CoinsInfo(), price));
        }

        [TestMethod]
        public void CoinsChangeNotEnoughCoinsInserted() // check how much coins to give back, not enough inserted
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(0);
            int price = 5;

            string expectedResult = "Insert more coins";
            Assert.AreEqual(expectedResult, coffeeMachine.DrinkChange(coffeeMachine.CoinsInfo(), price));
        }

        [TestMethod]
        public void CoinsChangePreciseCoinsInserted() // check how much coins to give back, precise amount of coins inserted
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(5);
            int price = 5;

            string expectedResult = "Precise number of coins inserted";
            Assert.AreEqual(expectedResult, coffeeMachine.DrinkChange(coffeeMachine.CoinsInfo(), price));
        }

        [TestMethod]
        public void CoinsChange1Coin() // check how much coins to give back, give back 1 coin
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(6);
            int price = 5;

            string expectedResult = "Giving back 1 coin";
            Assert.AreEqual(expectedResult, coffeeMachine.DrinkChange(coffeeMachine.CoinsInfo(), price));
        }

        [TestMethod]
        public void CoinsChangeMoreThan1Coin() // check how much coins to give back, give back more than 1 coin
        {
            CoffeeMachine coffeeMachine = new CoffeeMachine();
            coffeeMachine.InsertCoins(7);
            int price = 5;

            string expectedResult = "Giving back 2 coins";
            Assert.AreEqual(expectedResult, coffeeMachine.DrinkChange(coffeeMachine.CoinsInfo(), price));
        }
    }
}