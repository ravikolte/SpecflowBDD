using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace PageObjectModel_Specflow.Pages
{
    internal class OrangeHRM_VPage 
    {
        public IWebDriver driver;
        

        public OrangeHRM_VPage(IWebDriver driver)
        {
            this.driver = driver;
        }


        By username_textbox = By.Name("username");
        By password_textbox = By.Name("password");
        By login_btn = By.XPath("//button[@type='submit']");
        By PIM_Menu = By.XPath("//span[(text()=\"PIM\")]");
        By addEmployee = By.XPath("//a[contains(text(),'Add Employee')]");
        By firstName = By.Name("firstName");      
        By lastName = By.Name("lastName");
        By employee_List= By.XPath("//a[contains(text(),'Employee List')]");

        //Admin
        By adminTab = By.XPath("//span[(text()=\"Admin\")]");
        By AddAdminbutton = By.XPath("//i[@class='oxd-icon bi-plus oxd-button-icon']");
        By adminUserRole = By.XPath("//*[contains(text(),'User Role')]/following::div[1]/div/div/div[1]");
        By adminStatus = By.XPath("//*[contains(text(),'Status')]/following::div[1]/div/div/div[1]");
        By adminUserName = By.XPath("//*[contains(text(),'Username')]/following::div[1]/input");
        By adminEmployeeName = By.XPath("//*[contains(text(),'Employee Name')]/following::div[1]/div/div/input");
        By adminPass = By.XPath("//*[text()='Password']/following::div[1]/input");
        By adminconfirmPass = By.XPath("//*[text()='Confirm Password']/following::div[1]/input");

        //Leave
        By leaveTab = By.XPath("//span[text()='Leave']");
        By leavelistmenu = By.XPath("//a[contains(text(),'Leave List')]");
        By showLeavewithStatus = By.XPath("//*[contains(text(),'Show Leave with Status')]/following::div[1]/div/div/div[1]");
        By leaveSearch = By.XPath("//button[(text()=' Search ')]");
        By leaveNoResultFound = By.XPath("//span[(text()='No Records Found')]");

        //JOB
        By jobMenu = By.XPath("//span[text()='Job ']");
        By SaveButton = By.XPath("//button[@type='submit']");
        By NewUser= By.XPath("//div[@class='orangehrm-edit-employee-name']/h6");
        By addJob = By.XPath("//h6[text()='Job Titles']/following::button[1]");
        By Jobtitle = By.XPath("//*[text()='Job Title']/following::div[1]/input");
        By jobcreated = By.XPath("//div[@class=\"oxd-table-card\"]/div/div[2]/div[contains(text(),'ABD')]");
        By found = By.XPath("//div[@class='orangehrm-paper-container']/div[2]/div/span");
        By jobtitle = By.XPath("//a[text()='Job Titles']");

        By currentpast = By.XPath("//*[contains(text(),'Include')]/following::div[1]");
        By empName = By.XPath("//*[contains(text(),'Employee Name')]/following::input[1]");
        By empNameresult = By.XPath("//div[@class=\"oxd-table-card\"]/div/div[3]");
        By deleteEmp_icon = By.XPath("//div[@class=\"oxd-table-card\"]/div/div[9]/div/button[1]");
        By confirmDelete = By.XPath("//div[@class='orangehrm-modal-footer']/button[2]");
        By deleteJob_icon = By.XPath("//div[@class=\"oxd-table-body\"]/div[1]/div[1]/div[4]/div[1]/button[1]");
        
        public OrangeHRM_VPage click_deleteEmp_icon()
        {
            driver.FindElement(deleteEmp_icon).Click();
            return this;
        }
        public OrangeHRM_VPage click_deleteJob_icon()
        {
            driver.FindElement(deleteJob_icon).Click();
            return this;
        }
        public OrangeHRM_VPage click_confirmDelete()
        {
            driver.FindElement(confirmDelete).Click();
            return this;
        }
        public OrangeHRM_VPage click_currentpast()
        {
            IWebElement currpass = driver.FindElement(currentpast);
            currpass.Click();
            Thread.Sleep(5000);
            currpass.SendKeys(Keys.ArrowDown);
            currpass.SendKeys(Keys.ArrowDown);
            currpass.SendKeys(Keys.Tab);
            return this;
        }
        public string GetText_found()
        {
            String newusername = driver.FindElement(found).Text;
            return newusername;
        }
        public string GetText_empNameresult()
        {
            String newusername = driver.FindElement(empNameresult).Text;
            return newusername;
        }
        public OrangeHRM_VPage Search_empName(String searchname)
        {
            driver.FindElement(empName).SendKeys(searchname);
            return this;
        }
        public string GetText_jobcreated()
        {
            String newusername = driver.FindElement(jobcreated).Text;
            return newusername;
        }

        public OrangeHRM_VPage Fill_Jobtitle(string FirstName)
        {
            driver.FindElement(Jobtitle).SendKeys(FirstName);
            return this;
        }
        public OrangeHRM_VPage click_addJob()
        {
            driver.FindElement(addJob).Click();
            return this;
        }
        public OrangeHRM_VPage Fill_firstName(string FirstName)
        {            
            driver.FindElement(firstName).SendKeys(FirstName);
            return this;
        }
        public OrangeHRM_VPage Fill_lastName(string LastName)
        {
            driver.FindElement(lastName).SendKeys(LastName);
            return this;
        }
        public OrangeHRM_VPage click_SaveButton()
        {
            driver.FindElement(SaveButton).Click();
            return this;
        }
        public OrangeHRM_VPage click_PIM_Menu()
        {
            driver.FindElement(PIM_Menu).Click();
            return this;
        }
        public OrangeHRM_VPage click_AddEmployee()
        {
            driver.FindElement(addEmployee).Click();
            return this;
        }
        public OrangeHRM_VPage click_employee_List()
        {
            driver.FindElement(employee_List).Click();
            return this;
        }
        public OrangeHRM_VPage enter_username(string user)
        {
            driver.FindElement(username_textbox).SendKeys(user);
            return this;
        }
        public OrangeHRM_VPage enter_password(string pass)
        {
            driver.FindElement(password_textbox).SendKeys(pass);
            return this;
        }
        public OrangeHRM_VPage click_login_button()
        {
            driver.FindElement(login_btn).Click();
            return this;
        }

        //Admin--------------------------------------------------------------

        public OrangeHRM_VPage click_adminTab()
        {
            driver.FindElement(adminTab).Click();
            return this;
        }
        public OrangeHRM_VPage click_AddAdminbutton()
        {
            driver.FindElement(AddAdminbutton).Click();
            return this;
        }        
        public OrangeHRM_VPage click_adminUserRole()
        {
            IWebElement userrole = driver.FindElement(adminUserRole);
            userrole.Click();
            userrole.SendKeys(Keys.ArrowDown);
            userrole.SendKeys(Keys.ArrowDown);
            userrole.SendKeys(Keys.Enter);
            return this;
        }
        public OrangeHRM_VPage click_adminStatus()
        {
            //driver.FindElement(adminStatus).Click();
            IWebElement aStatus = driver.FindElement(adminStatus);
            aStatus.Click();
            aStatus.SendKeys(Keys.ArrowDown);
            aStatus.SendKeys(Keys.ArrowDown);
            aStatus.SendKeys(Keys.Enter);
            return this;
        }
        public OrangeHRM_VPage Fill_adminEmployeeName(string EmployeeName)
        {
            driver.FindElement(adminEmployeeName).SendKeys(EmployeeName);
            return this;
        }
        public OrangeHRM_VPage Fill_adminUserName(string Username)
        {
            driver.FindElement(adminUserName).SendKeys(Username);
            return this;
        }
        public OrangeHRM_VPage Fill_adminPass(string Password)
        {
            driver.FindElement(adminPass).SendKeys(Password);
            return this;
        }
        public OrangeHRM_VPage Fill_adminconfirmPass(string ConfirmPassword)
        {
            driver.FindElement(adminconfirmPass).SendKeys(ConfirmPassword);
            return this;
        }
        //Leave
        public OrangeHRM_VPage click_leaveTab()
        {
            driver.FindElement(leaveTab).Click();
            return this;
        }
        public OrangeHRM_VPage click_leavelistmenu()
        {
            driver.FindElement(leavelistmenu).Click();
            return this;
        }
        public OrangeHRM_VPage click_showLeavewithStatus()
        {
            driver.FindElement(showLeavewithStatus).Click();
            IWebElement LeaveStatus = driver.FindElement(showLeavewithStatus);
            LeaveStatus.Click();
            LeaveStatus.SendKeys(Keys.ArrowDown);
            LeaveStatus.SendKeys(Keys.ArrowDown);
            LeaveStatus.SendKeys(Keys.Enter);
            return this;
        }
        public OrangeHRM_VPage click_leaveSearch()
        {
            driver.FindElement(leaveSearch).Click();
            return this;
        }
        public string GetText_newUser()
        {
            String newusername = driver.FindElement(NewUser).Text;
            return newusername;
        }
        public string GetText_leaveNoResultFound()
        {
            String newusername = driver.FindElement(leaveNoResultFound).Text;
            return newusername;
        }
        //job
        public OrangeHRM_VPage click_jobtitle()
        {
            Actions s = new Actions(driver);
            IWebElement jobT = driver.FindElement(jobtitle);
            s.MoveToElement(jobT).Click().Perform();
            return this;
        }
        public OrangeHRM_VPage click_job()
        {
            IWebElement job = driver.FindElement(jobMenu);
            job.Click();
            Thread.Sleep(2000);
            click_jobtitle();
            return this;
        }
    }
}
