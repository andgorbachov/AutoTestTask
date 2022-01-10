using System.Collections.Generic;

namespace Atata.SpecFlow.Entities
{
    public static class OrderManager
    {
        /// <summary>
        ///     Creates / Updates the Order.
        /// </summary>
        /// <param name="peopleNumber">Number of people.</param>
        /// <param name="startersNumber">Number of startersNumber.</param>
        /// <param name="mainsNumber">Number of mainsNumber.</param>
        /// <param name="drinksNumber">Number of drinksNumber.</param>
        /// <param name="before19Number">Number of before19Number.</param>
        /// <returns>Returns the <see cref="Order"/>.</returns>
        public static Order CreateUpdateOrder(int peopleNumber, int startersNumber, int mainsNumber, int drinksNumber, bool before19Number)
        {
            Order order = new(peopleNumber, startersNumber, mainsNumber, drinksNumber, before19Number);
            order.AddToOrder();
            return order;
        }

        /// <summary>
        ///     Gets the Order Details as Dictionary.
        /// </summary>
        /// <param name="order">Order.</param>
        /// <returns>Returns the Order Details as Dictionary<string, string>.</returns>
        public static Dictionary<string, string> GetOrderDetails(Order order)
        {
            return order.GetDetails();
        }

        /// <summary>
        ///     Closes the Order - Clean/Reset Order data.
        /// </summary>
        /// <param name="order">Order.</param>
        public static void CloseOrder(Order order)
        {
            order.CloseOrder();
            Order.Total = 0;
        }
    }
}
