using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace PageObjectModel_Specflow

{
    public class Utility
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        public Utility(IWebDriver driver)
        {
            this.driver = driver;
        }
        public IWebElement FindElement(By by)
        {
            return driver.FindElement(by);
        }

        public void ClickElement(By by)
        {
            FindElement(by).Click();
        }

        public void SendKeys(By by, string text)
        {
            FindElement(by).SendKeys(text);
        }

        public string GetText(By by)
        {
            return FindElement(by).Text;
        }
    }
}
