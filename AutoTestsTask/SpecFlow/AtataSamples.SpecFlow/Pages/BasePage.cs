namespace Atata.SpecFlow.Pages
{
    public abstract class BasePage<TOwner> : Page<TOwner>
        where TOwner : BasePage<TOwner>
    {
        [VerifyExists]
        [FindByContent("Orders")]
        public Link<OrdersPage, TOwner> Orders { get; private set; }
    }
}
