using BoDi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;


namespace PageObjectModel_Specflow.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        


        [BeforeScenario]
        public void FirstBeforeScenario(ScenarioContext scenarioContext)
        {
           
            var tags = scenarioContext.ScenarioInfo.Tags;
          

            // Iterate through the tags and do not open browser if its a nonui test
            foreach (var tag in tags)
            {
                
                Console.WriteLine($"Tag: {tag}");
                if (!tag.Contains("nonui") || tag.Equals(string.Empty))
                {
                    Console.WriteLine("Running before scenario...");
                    
                    IWebDriver driver = new ChromeDriver("/opt/homebrew/bin/chromedriver");
                    driver.Manage().Window.Maximize();
                    driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);

                    _container.RegisterInstanceAs<IWebDriver>(driver);
                }

            }
            

           
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext scenarioContext)
        {
            Console.WriteLine("Running after scenario...");
            var tags = scenarioContext.ScenarioInfo.Tags;

            // Iterate through the tags and process them
            foreach (var tag in tags)
            {
                
                Console.WriteLine($"Tag: {tag}");
                if (!tag.Contains("nonui"))
                {
                    var driver = _container.Resolve<IWebDriver>();
                    if (driver != null)
                    {
                        driver.Quit();
                    }
                }
            }
        }

    }
}