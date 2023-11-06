using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel_Specflow.Pages
{
    public class LoginPage
    {
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        By username_textbox = By.Name("username");
        By password_textbox = By.Name("password");
        By login_btn = By.XPath("//button[@type='submit']");

        public LoginPage enter_username(string user)
        {
            driver.FindElement(username_textbox).SendKeys(user);
            return new LoginPage(driver);
        }

        public LoginPage enter_password(string pass)
        {
            driver.FindElement(password_textbox).SendKeys(pass);
            return new LoginPage(driver);
        }

        public LoginPage click_login_button()
        {
            driver.FindElement(login_btn).Click();
            Console.WriteLine("Clicking on Admin");
            return new LoginPage(driver);
        }
    }
}
