namespace Atata.SpecFlow.Components
{
    public class Order
    {
        public Order(int peopleNumber, int startersNumber, int mainsNumber, int drinksNumber, bool before19Number)
        {
            People = peopleNumber;
            Starters = startersNumber;
            Mains = mainsNumber;
            Drinks = drinksNumber;
            Before19 = before19Number;
        }

        public static double Total = 0;

        private int People { get; }
        private int Starters { get; }
        private int Mains { get; }
        private int Drinks { get; }
        private bool Before19 { get; }
        private double StarterPrice = GeneralConstants.StarterPrice;
        private double MainPrice = GeneralConstants.MainPrice;
        private double DrinkPrice = GeneralConstants.DrinkPrice;
        private double ServiceCharge = GeneralConstants.ServiceCharge;
        private double DrinkDiscount = GeneralConstants.DrinkDiscount;

        public double GetCosts()
        {
            var foodCosts = StarterPrice * Starters + MainPrice * Mains;
            var foodServiceCharge = foodCosts * ServiceCharge;
            var drinkCosts = Before19 ? DrinkPrice * Drinks - DrinkPrice * Drinks * DrinkDiscount : DrinkPrice * Drinks;
            var result = foodCosts + foodServiceCharge + drinkCosts;
            Total += result;
            return result;
        }
    }
}
