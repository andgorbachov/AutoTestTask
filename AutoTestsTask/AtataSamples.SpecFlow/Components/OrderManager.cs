using System.Collections.Generic;

namespace Atata.SpecFlow.Components
{
    public static class OrderManager
    {
        public static Order CreateUpdateOrder(int peopleNumber, int startersNumber, int mainsNumber, int drinksNumber, bool before19Number)
        {
            Order order = new(peopleNumber, startersNumber, mainsNumber, drinksNumber, before19Number);
            order.AddToOrder();
            return order;
        }

        public static Dictionary<string, string> GetOrderDetails(Order order)
        {
            return order.GetDetails();
        }

        public static void CloseOrder(Order order)
        {
            order.CloseOrder();
            Order.Total = 0;
        }
    }
}
