using System;
using Atata.SpecFlow.Components;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Atata.SpecFlow.StepDefinitions
{
    [Binding]
    public sealed class CalculationsSteps : BaseSteps
    {
        [Given(@"A group of (.*) people orders (.*) starters, (.*) mains and (.*) drinks before 19-00 (.*)")]
        public void GivenAGroupOfPeopleOrdersStartersMainsAndDrinksBeforeTrue(int people, int starters, int mains, int drinks, bool before19)
        {
            // Templates for future UI 
            //On<OrdersPage>().
            //    Starters.Set(starters).
            //    Mains.Set(mains).
            //    Drinks.Set(drinks).
            //    Before19.Set(before19);

            Order order = new(people, starters, mains, drinks, before19);
            order.GetCosts();
        }
        
        [When(@"A group of (.*) people orders (.*) starters, (.*) mains and (.*) drinks and before 19-00 (.*)")]
        public void WhenAGroupOfPeopleOrdersStartersMainsAndDrinksAndBeforeFalseHours(int people, int starters, int mains, int drinks, bool before19)
        {
            // Templates for future UI 
            //On<OrdersPage>().
            //    Starters.Set(starters).
            //    Mains.Set(mains).
            //    Drinks.Set(drinks).
            //    Before19.Set(before19);

            Order order = new(people, starters, mains, drinks, before19);
            order.GetCosts();
        }

        [When(@"The order is sent to the endpoint")]
        public void WhenTheOrderIsSentToTheEndpoint()
        {
            // Templates for future UI 
            //On<OrdersPage>().SubmitOrder.Click();
            Console.WriteLine("WhenTheOrderIsSentToTheEndpoint");
        }

        [Then(@"The (.*) total is calculated correctly")]
        public void ThenTheTotalIsCalculatedCorrectly(double result)
        {
            // Templates for future UI 
            //On<OrdersPage>().Result.Should.Equal(result);
            double TOLERANCE = 0.1;
            Assert.True(Math.Abs(Order.Total - result) < TOLERANCE);
            Order.Total = 0;
        }
    }
}
