using System.Collections.Generic;
using System.Globalization;

namespace Atata.SpecFlow.Entities
{
    public class Order
    {
        public Order(int peopleNumber, int startersNumber, int mainsNumber, int drinksNumber, bool before19Number = false)
        {
            People = peopleNumber;
            Starters = startersNumber;
            Mains = mainsNumber;
            Drinks = drinksNumber;
            Before19 = before19Number;
        }

        public static double Total = 0;

        private int People { get; set; }
        private int Starters { get; set; }
        private int Mains { get; set; }
        private int Drinks { get; set; }
        private bool Before19 { get; set; }
        private double StarterPrice = GeneralConstants.StarterPrice;
        private double MainPrice = GeneralConstants.MainPrice;
        private double DrinkPrice = GeneralConstants.DrinkPrice;
        private double ServiceCharge = GeneralConstants.ServiceCharge;
        private double DrinkDiscount = GeneralConstants.DrinkDiscount;

        /// <summary>
        ///     Calculates and adds the sum to the Order Total.
        /// </summary>
        /// <returns>Returns the sum added to the Order.</returns>
        public double AddToOrder()
        {
            var foodCosts = StarterPrice * Starters + MainPrice * Mains;
            var foodServiceCharge = foodCosts * ServiceCharge;
            var drinkCosts = Before19 ? DrinkPrice * Drinks - DrinkPrice * Drinks * DrinkDiscount : DrinkPrice * Drinks;
            var result = foodCosts + foodServiceCharge + drinkCosts;
            Total += result;
            return result;
        }

        /// <summary>
        ///     Gets the Order Details as Dictionary.
        /// </summary>
        /// <returns>Returns the Order Details as Dictionary<string, string>.</returns>
        public Dictionary<string, string> GetDetails()
        {
            var details = new Dictionary<string, string>()
            {
                { "people", People.ToString() },
                { "starters", Starters.ToString() },
                { "mains", Mains.ToString() },
                { "drinks", Drinks.ToString() },
                { "before19", Before19.ToString() },
                { "total", Total.ToString(CultureInfo.InvariantCulture) }
            };
            return details;
        }

        /// <summary>
        ///     Closes the Order - Clean/Reset Order data.
        /// </summary>
        /// <param name="order">Order.</param>
        public void CloseOrder()
        {
            People = 0;
            Starters = 0;
            Mains = 0;
            Drinks = 0;
        }
    }
}
