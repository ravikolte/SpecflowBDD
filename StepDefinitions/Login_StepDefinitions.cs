using OpenQA.Selenium;
using PageObjectModel_Specflow.ConstantHelpers;
using PageObjectModel_Specflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace PageObjectModel_Specflow.StepDefinitions
{
    [Binding]
    public sealed class Login_StepDefinitions
    {
        private IWebDriver driver;
        LoginPage loginPage;

        public Login_StepDefinitions(IWebDriver driver)
        {
            this.driver = driver;
            loginPage = new LoginPage(driver);
        }
        
        [Given(@"Given I am on the login page")]
        public void GivenGivenIAmOnTheLoginPage()
        {
            driver.Navigate().GoToUrl(FrameworkConstants.WebUrl);
        }

        [Given(@"I enter username ""([^""]*)""")]
        public void GivenIEnterUsername(string admin)
        {
            loginPage.enter_username(admin);
        }

        [Then(@"I enter password ""([^""]*)""")]
        public void ThenIEnterPassword(string p0)
        {
            loginPage.enter_password(p0);
        }

        [Then(@"click on login button")]
        public void ThenClickOnLoginButton()
        {
            loginPage.click_login_button();
        }

      
    }
}
