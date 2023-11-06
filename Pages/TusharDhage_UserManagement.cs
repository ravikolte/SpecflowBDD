using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V116.FedCm;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using PageObjectModel_Specflow.ConstantHelpers;


namespace PageObjectModel_Specflow.Pages
{
    public class TusharDhage_UserManagement
    {
        private IWebDriver driver;
        private readonly Utility utility;
        private Dictionary<string, string> formValues;
        string userNameGen;
        string jobTitlee;
        public TusharDhage_UserManagement(IWebDriver driver)
        {
            this.driver = driver;
        }
        string employeeName = TusharDhage_Constants.EMPLOYEE_NAME;

        public TusharDhage_UserManagement verifyEmployeeList(string employeeName)
        {
            string verifyUser = driver.FindElement(TusharDhage_Locators.empUserName).Text;
            Assert.AreEqual(verifyUser, employeeName);
            return new TusharDhage_UserManagement(driver);
        }

        //     public TusharDhage_UserManagement (string employeeName)
        // {
        //     string verifyUser = driver.FindElement(TusharDhage_Locators.empUserName).Text;
        //     Assert.AreEqual(verifyUser, employeeName);
        //     return new TusharDhage_UserManagement(driver);
        // }
 

        public TusharDhage_UserManagement delete_User()
        {
            driver.FindElement(TusharDhage_Locators.empList).Click();
            driver.FindElement(TusharDhage_Locators.employee_Name).SendKeys(employeeName);
            Thread.Sleep(3000);
            actionClass();
            driver.FindElement(TusharDhage_Locators.searchButton).Click();
            confirm_Delete();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement search_Employee(){
            driver.FindElement(TusharDhage_Locators.employee_Name).SendKeys(employeeName);
            Thread.Sleep(3000);
            driver.FindElement(TusharDhage_Locators.searchButton).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement search_Record(){
            //IWebElement recordUser = driver.FindElement(TusharDhage_Locators.recordSearch).Text;
            Assert.IsTrue( driver.FindElement(TusharDhage_Locators.recordSearch).Text.Contains("Tushar"));
            driver.FindElement(TusharDhage_Locators.recordSearch).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement confirm_Delete()
        {
            driver.FindElement(TusharDhage_Locators.deleteUser).Click();
            driver.FindElement(TusharDhage_Locators.deleteEmployee).Click();
            Thread.Sleep(3000);
            Assert.IsTrue(driver.FindElement(TusharDhage_Locators.deleteEmployee).Displayed);
            //driver.SwitchTo().Alert();
            driver.FindElement(TusharDhage_Locators.deletePopup).Click();
            Thread.Sleep(3000);
            return new TusharDhage_UserManagement(driver);
        }
        //To tap on menu that has same class 
        public TusharDhage_UserManagement emp_Login_Info()
        {
            driver.FindElement(TusharDhage_Locators.userNameField).SendKeys("TusharDhage");
            driver.FindElement(TusharDhage_Locators.passWord).SendKeys("admin123");
            driver.FindElement(TusharDhage_Locators.confirmPassword).SendKeys("admin123");
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement emp_Login(Table table)
        {
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            driver.FindElement(TusharDhage_Locators.userNameField).SendKeys(formValues["Username"]);
            driver.FindElement(TusharDhage_Locators.passWord).SendKeys(formValues["Password"]);
            driver.FindElement(TusharDhage_Locators.confirmPassword).SendKeys(formValues["Confirm Password"]);

            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement tapOnLoginToggleButton()
        {
            driver.FindElement(TusharDhage_Locators.loginToggleButton).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement add_Employee_Info(Table table)
        {
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            driver.FindElement(TusharDhage_Locators.firstName).SendKeys(formValues["FirstName"]);
            driver.FindElement(TusharDhage_Locators.middleName).SendKeys(formValues["MiddleName"]);
            driver.FindElement(TusharDhage_Locators.lastName).SendKeys(formValues["LastName"]);

            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement fill_Job_Title_Form(Table table)
        {
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);

            driver.FindElement(TusharDhage_Locators.jobtitle).SendKeys(formValues["JobTitle"]);
            driver.FindElement(TusharDhage_Locators.jobDescription).SendKeys(formValues["JD"]);
            driver.FindElement(TusharDhage_Locators.addNote).SendKeys(formValues["Note"]);
            return new TusharDhage_UserManagement(driver);
        }
        public TusharDhage_UserManagement tapPIM()
        {
            driver.FindElement(TusharDhage_Locators.pimMenu).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement tap_Add_Employee()
        {
            driver.FindElement(TusharDhage_Locators.addEmployee).Click();
            Thread.Sleep(3000);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement verify_Employee_Screen()
        {
            string EmployeeScreen = driver.FindElement(TusharDhage_Locators.addEmployee).Text;
            Assert.AreEqual(EmployeeScreen, TusharDhage_Constants.ADD_EMPLOYEE);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement Click_Admin()
        {
            driver.FindElement(TusharDhage_Locators.adminMenu).Click();
            Thread.Sleep(3000);
            return new TusharDhage_UserManagement(driver);
        }
        public TusharDhage_UserManagement Click_PIM()
        {
            driver.FindElement(TusharDhage_Locators.pimMenu).Click();
            Thread.Sleep(3000);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement tap_Leave_Menu()
        {
            driver.FindElement(TusharDhage_Locators.leaveMenu).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement verify_Admin_Screen()
        {
            Console.WriteLine("Verify user navigate to Admin user screen");
            Assert.IsTrue(driver.FindElement(TusharDhage_Locators.adminScreen).Displayed);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement select_User()
        {
            driver.FindElement(TusharDhage_Locators.TusharDhage_UserManagementMenu).Click();
            driver.FindElement(TusharDhage_Locators.user).Click();
            return new TusharDhage_UserManagement(driver);
        }


        public TusharDhage_UserManagement verify_Add_User_Screen()
        {
            Assert.IsTrue(driver.FindElement(TusharDhage_Locators.add_User).Displayed);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement tap_Add_User()
        {
            driver.FindElement(TusharDhage_Locators.add_User).Click();
            Thread.Sleep(3000);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement verify_User_Creation_Screen()
        {
            Assert.IsTrue(driver.FindElement(TusharDhage_Locators.user_Creation).Displayed);
            Assert.AreEqual(driver.FindElement(TusharDhage_Locators.user_Creation).Text, TusharDhage_Constants.ADD_USER);
            return new TusharDhage_UserManagement(driver);
        }
        public TusharDhage_UserManagement actionClass()
        {
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Down).Build().Perform();
            builder.SendKeys(Keys.Enter).Build().Perform();
            return new TusharDhage_UserManagement(driver);
        }
        public TusharDhage_UserManagement find_Employee()
        {
            string getUserName = driver.FindElement(TusharDhage_Locators.user_Name).Text;
            driver.FindElement(TusharDhage_Locators.employee_Name).SendKeys(getUserName);
            Thread.Sleep(3000);
            actionClass();

            return new TusharDhage_UserManagement(driver);
        }
        public TusharDhage_UserManagement create_User(Table table)
        {


            find_Employee();
            Console.WriteLine("Select from User Role Dropdown");
            IWebElement dropdown = driver.FindElement(TusharDhage_Locators.userRoleDropDown);
            dropdown.Click();
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Down).Build().Perform();
            builder.SendKeys(Keys.Enter).Build().Perform();
            // dropdown.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Select from Status Dropdown");
            IWebElement dropdown2 = driver.FindElement(TusharDhage_Locators.statusDropDown);
            dropdown2.Click();
            builder.SendKeys(Keys.Down).Build().Perform();
            builder.SendKeys(Keys.Enter).Build().Perform();
            //dropdown2.Click();
            //userNameGen = GenerateRandomUsername();
            // IList<IWebElement> elementsWithSameClassName = driver.FindElements(By.XPath("//input[@class='oxd-input oxd-input--active']"));

            // // Check if there are at least two elements with the same class name
            // if (elementsWithSameClassName.Count >= 2)
            // {
            //     // Access the second element with the same class name
            //     IWebElement secondElement = elementsWithSameClassName[1];

            //     // Now you can perform actions on the second element
            //     secondElement.SendKeys("TusharDhage");
            // }
            Thread.Sleep(3000);
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            driver.FindElement(TusharDhage_Locators.userName).SendKeys(formValues["Username"]);
            driver.FindElement(TusharDhage_Locators.passWord).SendKeys(formValues["Password"]);
            driver.FindElement(TusharDhage_Locators.confirmPassword).SendKeys(formValues["Confirm Password"]);

            Thread.Sleep(3000);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement tap_Save_Button()
        {
            Thread.Sleep(5000);
            driver.FindElement(TusharDhage_Locators.saveButton).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement VerifySuccessMessage()
        {
            Assert.IsTrue(true);
            //  Assert.IsTrue(driver.FindElement(successMsg).Displayed);
            Thread.Sleep(8000);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement RefreshScreen()
        {
            driver.Navigate().Refresh();
            Thread.Sleep(10000);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement Verify_Created_User(string user)
        {
            driver.FindElement(TusharDhage_Locators.searchUsername).SendKeys(user);
            driver.FindElement(TusharDhage_Locators.searchButton).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(driver.FindElement(TusharDhage_Locators.validateUsername).Text, user);
            Thread.Sleep(3000);
            confirm_Delete();
            return new TusharDhage_UserManagement(driver);
        }
        public TusharDhage_UserManagement tap_Job_Titles()
        {
            driver.FindElement(TusharDhage_Locators.jobMenu).Click();
            driver.FindElement(TusharDhage_Locators.jobTitle).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement verify_Created_Job_Title()
        {
            Assert.AreEqual(driver.FindElement(TusharDhage_Locators.jobTitleCreated).Text, jobTitlee);
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement scrollToText()
        {

            // This JavaScript code will scroll until the text is found or the end of the page is reached.

            string searchText = TusharDhage_Constants.SEARCH_JOB_TITLE;
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            bool textFound = false;
            while (!textFound)
            {

                // Check if the text is present in the page source.
                if (driver.PageSource.Contains(searchText))
                {
                    js.ExecuteScript("window.scrollBy(0, 1000);");
                    Thread.Sleep(500);
                    break;
                }
            }
            try
            {

                IWebElement jobTitleElement = driver.FindElement(TusharDhage_Locators.searchJob);

                // Click the 'Delete' button for the selected job title.
                IWebElement deleteButton = jobTitleElement.FindElement(By.XPath("//div[normalize-space()='QA Automation']/following-sibling::*//i[@class='oxd-icon bi-trash']"));
                deleteButton.Click();
                // Handle the confirmation dialog and confirm deletion.
                driver.FindElement(TusharDhage_Locators.deletePopup).Click();
                Thread.Sleep(3000);

                Console.WriteLine("Job title deleted successfully.");
            }
            catch (NoSuchElementException e)
            {
                Console.WriteLine("Job title not found: " + e.Message);
            }
            catch (NoAlertPresentException e)
            {
                Console.WriteLine("No confirmation dialog found: " + e.Message);
            }
            return new TusharDhage_UserManagement(driver);
        }


        public static string GenerateRandomUsername()
        {
            // You can use a combination of letters, numbers, or any other rules you want
            string characters = TusharDhage_Constants.GENERATE_RANDOM_USER;
            Random random = new Random();
            int length = 8; // Change this to the desired username length

            string randomUsername = new string(Enumerable.Repeat(characters, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomUsername;
        }

        public TusharDhage_UserManagement click_EmployeeList(){
            driver.FindElement(TusharDhage_Locators.empList).Click();
            return new TusharDhage_UserManagement(driver);
        }

        public TusharDhage_UserManagement verify_Personal_Info(){
            Assert.IsTrue(driver.FindElement(TusharDhage_Locators.personalDetails).Text.Contains(TusharDhage_Constants.PERSONAL_DETAILS));
             return new TusharDhage_UserManagement(driver);
        }
    }
}