namespace Atata.SpecFlow.Pages
{
    using _ = OrdersPage;

    [Url("orders")]
    public class OrdersPage : BasePage<_>
    {
        [FindById]
        public Input<int, _> Starters { get; private set; }

        [FindById]
        public Input<int, _> Mains { get; private set; }

        [FindById]
        public Input<int, _> Drinks { get; private set; }

        [FindById]
        public CheckBox<_> Before19 { get; private set; }

        [FindById]
        public Link<_> SubmitOrder { get; private set; }

        [FindById]
        public Input<int, _> Result { get; private set; }
    }
}
