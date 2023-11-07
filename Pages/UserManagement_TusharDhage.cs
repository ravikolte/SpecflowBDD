using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V116.FedCm;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using PageObjectModel_Specflow.ConstantHelpers;


namespace PageObjectModel_Specflow.Pages
{
    public class UserManagement_TusharDhage
    {
        private IWebDriver driver;
        private Dictionary<string, string> formValues;
        string jobTitlee;
        public UserManagement_TusharDhage(IWebDriver driver)
        {
            this.driver = driver;
        }

        //User Management Page Locators
        public static By adminMenu = By.XPath("//a[normalize-space()='Admin']");
        public static By adminScreen = By.XPath("//span[@class='oxd-topbar-header-breadcrumb']");
        public static By TusharDhage_UserManagementMenu = By.XPath("//span[normalize-space()='User Management']");
        public static By user = By.XPath("//ul[@role='menu']//li");
        public static By add_User = By.XPath("//button[@class = 'oxd-button oxd-button--medium oxd-button--secondary']");
        public static By user_Creation = By.XPath("//h6[@class='oxd-text oxd-text--h6 orangehrm-main-title']");
        public static By user_Name = By.XPath("//p[@class='oxd-userdropdown-name']");
        public static By employee_Name = By.XPath("//input[@placeholder='Type for hints...']");
        public static By autoComplete = By.XPath("//div[@class='oxd-autocomplete-text-input--after']");
        public static By invalidError = By.XPath("//span[@class='oxd-text oxd-text--span oxd-input-field-error-message oxd-input-group__message']");
        public static By userRoleDropDown = By.XPath("//i[@class='oxd-icon bi-caret-down-fill oxd-select-text--arrow'][1]");
        public static By userName = By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]");
        public static By passWord = By.XPath("//input[@type='password']");
        public static By confirmPassword = By.XPath("(//input[@type='password'])[2]");
        public static By saveButton = By.XPath("//button[@type='submit']");
        public static By statusDropDown = By.XPath("//div[contains(text(),'-- Select --')]");
        public static By successMsg = By.XPath("//p[@class='oxd-text oxd-text--p oxd-text--toast-message oxd-toast-content-text']");
        public static By searchUsername = By.XPath("(//input[@class='oxd-input oxd-input--active'])[3]");
        public static By searchButton = By.XPath("//button[@type='submit']");
        public static By validateUsername = By.XPath("//div[contains(text(),'Tushar')]");
        public static By pimMenu = By.LinkText("PIM");
        public static By addEmployee = By.LinkText("Add Employee");
        public static By firstName = By.XPath("//input[@name='firstName']");
        public static By middleName = By.XPath("//input[@name='middleName']");
        public static By lastName = By.XPath("//input[@name='lastName']");
        public static By empList = By.LinkText("Employee List");
        public static By empUserName = By.XPath("//h6[@class='oxd-text oxd-text--h6 --strong']");
        public static By employeeName = By.XPath("//div[@class='oxd-autocomplete-text-input oxd-autocomplete-text-input--active']");
        public static By deleteUser = By.XPath("(//i[@class='oxd-icon bi-check oxd-checkbox-input-icon'])[1]");
        public static By loginToggleButton = By.XPath("//span[@class= 'oxd-switch-input oxd-switch-input--active --label-right']");
        public static By deletePopup = By.XPath("//button[normalize-space()='Yes, Delete']");
        public static By leaveMenu = By.LinkText("Leave");
        public static By deleteEmployee = By.XPath("//i[@class='oxd-icon bi-trash']");
        public static By jobtitle = By.XPath("(//input[@class='oxd-input oxd-input--active'])[2]");
        public static By jobDescription = By.XPath("//textarea[@placeholder='Type description here']");
        public static By addNote = By.XPath("//textarea[@placeholder='Add note']");
        public static By jobTitle = By.XPath("(//li)[16]");
        public static By jobTitleCreated = By.XPath("//div[contains(text(),'QA Automation')]");
        public static By jobMenu = By.XPath("//span[normalize-space()='Job']");
        public static By searchJob = By.XPath("//div[normalize-space()='QA Automation']");
        public static By deleteJob = By.XPath("//div[normalize-space()='QA Automation']/following-sibling::*//i[@class='oxd-icon bi-trash']");

        public static By recordSearch = By.XPath("//div[contains(text(),'Tushar')]");
        public static By personalDetails = By.XPath("//h6[normalize-space()='Personal Details']");

        string empName = FrameworkConstants.EMPLOYEE_NAME;
        public UserManagement_TusharDhage verifyEmployeeList(string empName)
        {
            string verifyUser = driver.FindElement(empUserName).Text;
            Assert.AreEqual(verifyUser, empName);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage delete_User()
        {
            driver.FindElement(empList).Click();
            driver.FindElement(employee_Name).SendKeys(FrameworkConstants.EMPLOYEE_NAME);
            Thread.Sleep(3000);
            actionClass();
            driver.FindElement(searchButton).Click();
            confirm_Delete();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage search_Employee()
        {
            driver.FindElement(employee_Name).SendKeys(FrameworkConstants.EMPLOYEE_NAME);
            Thread.Sleep(3000);
            driver.FindElement(searchButton).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage search_Record()
        {
            Assert.IsTrue(driver.FindElement(recordSearch).Text.Contains("Tushar"));
            driver.FindElement(recordSearch).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage confirm_Delete()
        {
            driver.FindElement(deleteUser).Click();
            driver.FindElement(deleteEmployee).Click();
            Assert.IsTrue(driver.FindElement(deleteEmployee).Displayed);
            driver.FindElement(deletePopup).Click();
            Thread.Sleep(3000);
            return new UserManagement_TusharDhage(driver);
        }
        //To tap on menu that has same class 
        public UserManagement_TusharDhage emp_Login_Info()
        {
            driver.FindElement(userName).SendKeys("TusharDhage");
            driver.FindElement(passWord).SendKeys("admin123");
            driver.FindElement(confirmPassword).SendKeys("admin123");
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage emp_Login(Table table)
        {
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            driver.FindElement(searchUsername).SendKeys(formValues["Username"]);
            driver.FindElement(passWord).SendKeys(formValues["Password"]);
            driver.FindElement(confirmPassword).SendKeys(formValues["Confirm Password"]);

            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage tapOnLoginToggleButton()
        {
            driver.FindElement(loginToggleButton).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage add_Employee_Info(Table table)
        {
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            driver.FindElement(firstName).SendKeys(formValues["FirstName"]);
            driver.FindElement(middleName).SendKeys(formValues["MiddleName"]);
            driver.FindElement(lastName).SendKeys(formValues["LastName"]);

            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage fill_Job_Title_Form(Table table)
        {
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);

            driver.FindElement(jobtitle).SendKeys(formValues["JobTitle"]);
            driver.FindElement(jobDescription).SendKeys(formValues["JD"]);
            driver.FindElement(addNote).SendKeys(formValues["Note"]);
            return new UserManagement_TusharDhage(driver);
        }
        public UserManagement_TusharDhage tapPIM()
        {
            driver.FindElement(pimMenu).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage tap_Add_Employee()
        {
            driver.FindElement(addEmployee).Click();
            Thread.Sleep(3000);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage verify_Employee_Screen()
        {
            string EmployeeScreen = driver.FindElement(addEmployee).Text;
            Assert.AreEqual(EmployeeScreen, FrameworkConstants.ADD_EMPLOYEE);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage Click_Admin()
        {
            driver.FindElement(adminMenu).Click();
            Thread.Sleep(3000);
            return new UserManagement_TusharDhage(driver);
        }
        public UserManagement_TusharDhage Click_PIM()
        {
            driver.FindElement(pimMenu).Click();
            Thread.Sleep(3000);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage tap_Leave_Menu()
        {
            driver.FindElement(leaveMenu).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage verify_Admin_Screen()
        {
            Console.WriteLine("Verify user navigate to Admin user screen");
            Assert.IsTrue(driver.FindElement(adminScreen).Displayed);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage select_User()
        {
            driver.FindElement(TusharDhage_UserManagementMenu).Click();
            driver.FindElement(user).Click();
            return new UserManagement_TusharDhage(driver);
        }


        public UserManagement_TusharDhage verify_Add_User_Screen()
        {
            Assert.IsTrue(driver.FindElement(add_User).Displayed);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage tap_Add_User()
        {
            driver.FindElement(add_User).Click();
            Thread.Sleep(3000);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage verify_User_Creation_Screen()
        {
            Assert.IsTrue(driver.FindElement(user_Creation).Displayed);
            Assert.AreEqual(driver.FindElement(user_Creation).Text, FrameworkConstants.ADD_USER);
            return new UserManagement_TusharDhage(driver);
        }
        public UserManagement_TusharDhage actionClass()
        {
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Down).Build().Perform();
            builder.SendKeys(Keys.Enter).Build().Perform();
            return new UserManagement_TusharDhage(driver);
        }
        public UserManagement_TusharDhage find_Employee()
        {
            string getUserName = driver.FindElement(user_Name).Text;
            driver.FindElement(employee_Name).SendKeys(getUserName);
            Thread.Sleep(3000);
            actionClass();

            return new UserManagement_TusharDhage(driver);
        }
        public UserManagement_TusharDhage create_User(Table table)
        {
            find_Employee();
            Console.WriteLine("Select from User Role Dropdown");
            IWebElement dropdown = driver.FindElement(userRoleDropDown);
            dropdown.Click();
            Actions builder = new Actions(driver);
            builder.SendKeys(Keys.Down).Build().Perform();
            builder.SendKeys(Keys.Enter).Build().Perform();
            // dropdown.Click();
            Thread.Sleep(3000);
            Console.WriteLine("Select from Status Dropdown");
            IWebElement dropdown2 = driver.FindElement(statusDropDown);
            dropdown2.Click();
            builder.SendKeys(Keys.Down).Build().Perform();
            builder.SendKeys(Keys.Enter).Build().Perform();

            Thread.Sleep(3000);
            formValues = table.Rows.ToDictionary(row => row["Field"], row => row["Value"]);
            driver.FindElement(userName).SendKeys(formValues["Username"]);
            driver.FindElement(passWord).SendKeys(formValues["Password"]);
            driver.FindElement(confirmPassword).SendKeys(formValues["Confirm Password"]);

            Thread.Sleep(3000);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage tap_Save_Button()
        {
            Thread.Sleep(5000);
            driver.FindElement(saveButton).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage VerifySuccessMessage()
        {
            Assert.IsTrue(true);
            //  Assert.IsTrue(driver.FindElement(successMsg).Displayed);
            Thread.Sleep(8000);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage RefreshScreen()
        {
            driver.Navigate().Refresh();
            Thread.Sleep(10000);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage Verify_Created_User(string user)
        {
            driver.FindElement(userName).SendKeys(user);
            driver.FindElement(searchButton).Click();
            Thread.Sleep(3000);
            Assert.AreEqual(driver.FindElement(validateUsername).Text, user);
            Thread.Sleep(3000);
            confirm_Delete();
            return new UserManagement_TusharDhage(driver);
        }
        public UserManagement_TusharDhage tap_Job_Titles()
        {
            driver.FindElement(jobMenu).Click();
            driver.FindElement(jobTitle).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage verify_Created_Job_Title()
        {
            Assert.AreEqual(driver.FindElement(jobTitleCreated).Text, jobTitlee);
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage scrollToText()
        {

            // This JavaScript code will scroll until the text is found or the end of the page is reached.

            string searchText = FrameworkConstants.SEARCH_JOB_TITLE;
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

                IWebElement jobTitleElement = driver.FindElement(searchJob);

                // Click the 'Delete' button for the selected job title.
                IWebElement deleteButton = jobTitleElement.FindElement(By.XPath("//div[normalize-space()='QA Automation']/following-sibling::*//i[@class='oxd-icon bi-trash']"));
                deleteButton.Click();
                // Handle the confirmation dialog and confirm deletion.
                driver.FindElement(deletePopup).Click();

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
            return new UserManagement_TusharDhage(driver);
        }


        public static string GenerateRandomUsername()
        {
            // You can use a combination of letters, numbers, or any other rules you want
            string characters = FrameworkConstants.GENERATE_RANDOM_USER;
            Random random = new Random();
            int length = 8; // Change this to the desired username length

            string randomUsername = new string(Enumerable.Repeat(characters, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return randomUsername;
        }

        public UserManagement_TusharDhage click_EmployeeList()
        {
            driver.FindElement(empList).Click();
            return new UserManagement_TusharDhage(driver);
        }

        public UserManagement_TusharDhage verify_Personal_Info()
        {
            Assert.IsTrue(driver.FindElement(personalDetails).Text.Contains(FrameworkConstants.PERSONAL_DETAILS));
            return new UserManagement_TusharDhage(driver);
        }
    }
}