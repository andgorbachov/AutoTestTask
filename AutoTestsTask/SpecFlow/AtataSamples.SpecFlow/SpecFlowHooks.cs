using Atata.SpecFlow.Components;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Infrastructure;

namespace Atata.SpecFlow
{
    [Binding]
    public sealed class SpecFlowHooks
    {
        private readonly ISpecFlowOutputHelper _outputHelper;

        public SpecFlowHooks(ISpecFlowOutputHelper outputHelper)
        {
            _outputHelper = outputHelper;
        }

        [BeforeTestRun]
        public static void SetUpTestRun()
        {
            AtataContext.GlobalConfiguration
                .UseChrome()
                    .WithArguments("start-maximized")
                .UseBaseUrl("http://google.com/")
                .UseCulture("en-GB")
                .UseNUnitTestName()
                .UseNUnitTestSuiteName()
                .UseNUnitTestSuiteType()
                .UseNUnitAssertionExceptionType()
                .UseNUnitAggregateAssertionStrategy()
                .UseNUnitWarningReportStrategy()
                .LogNUnitError()
                .TakeScreenshotOnNUnitError()
                .AddScreenshotFileSaving()
                    .WithArtifactsFolderPath();

            AtataContext.GlobalConfiguration.AutoSetUpDriverToUse();
        }

        [BeforeScenario]
        public void SetUpScenario()
        {
            AtataContext.Configure()
                .EventSubscriptions.Add<ScreenshotFileSavedEvent>(eventData => _outputHelper.AddAttachment(eventData.FilePath))
                .AddLogConsumer(new TextOutputLogConsumer(_outputHelper.WriteLine))
                .Build();
        }

        [AfterScenario]
        public void TearDownScenario()
        {
            AtataContext.Current?.CleanUp();
        }
    }
}
