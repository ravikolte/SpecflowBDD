using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectModel_Specflow.ConstantHelpers;
using PageObjectModel_Specflow.Pages;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace PageObjectModel_Specflow.StepDefinitions
{
    [Binding]
    internal class Steps_Vinayak
    {
        private IWebDriver driver;

        OrangeHRM_VPage OHRMPage;

        
        //LoginPage loginPage;
        public Steps_Vinayak(IWebDriver driver)
        {
            this.driver = driver;
            OHRMPage = new OrangeHRM_VPage(driver);
        }
        [Given(@"I have successfully loggin to OrangeHRM")]
        public void GivenIHaveSuccessfullyLogginToOrangeHRM()
        {
            driver.Navigate().GoToUrl(FrameworkConstants.WebUrl);
        }
        [Given(@"I click on PIM Tab")]
        public void GivenIClickOnPIMTab()
        {
            OHRMPage.click_PIM_Menu();
        }
        [When(@"I click on Add Emloyee tab")]
        public void WhenIClickOnAddEmloyeeOption()
        {
            OHRMPage.click_AddEmployee();
        }
        [When(@"I click on Employee_list tab")]
        public void WhenIClickOnEmployee_ListTab()
        {
            OHRMPage.click_employee_List();
        }
        [When(@"I click on save button")]
        public void WhenIClickOnSaveButton()
        {
            OHRMPage.click_SaveButton();
        }

        [When(@"I fill the Employee details")]
        public void WhenIFillTheEmployeeDetails(Table table)
        {
            // Retrieve data from the DataTable
            var emp = table.CreateInstance<HRMEmpInfo>(); 

            // Fill the fields using the retrieved data
            OHRMPage.Fill_firstName(emp.FirstName);
            OHRMPage.Fill_lastName(emp.LastName);
        }

        [Then(@"I should see the new employee ""([^""]*)"" is created")]
        public void ThenIShouldSeeTheNewEmployeeIsCreated(string expected)
        {
            Thread.Sleep(8000);
            string actualtext = OHRMPage.GetText_newUser();
            Assert.AreEqual(expected, actualtext);
        }
        [Then(@"I should see the new employee Name as ""([^""]*)"" is created")]
        public void ThenIShouldSeeTheNewEmployeeNameAsIsCreated(string expected)
        {
            Thread.Sleep(5000);
            string actualtext = OHRMPage.GetText_empNameresult();
            Assert.AreEqual(expected, actualtext);
        }
        [Then(@"I delete the created employee")]
        public void ThenIDeleteTheCreatedEmployee()
        {
            OHRMPage.click_deleteEmp_icon();
            OHRMPage.click_confirmDelete();
        }
        [Then(@"I delete the created job")]
        public void ThenIDeleteTheCreatedJob()
        {
            OHRMPage.click_deleteJob_icon();
            OHRMPage.click_confirmDelete();
        }

        //========================================================================

        [Given(@"I click on Admin Tab")]
        public void GivenIClickOnAdminTab()
        {
            OHRMPage.click_adminTab();
        }
        [When(@"I click on AddAdmin Button")]
        public void WhenIClickOnAddAdminTab()
        {
            OHRMPage.click_AddAdminbutton();
           ////// throw new PendingStepException();
        }

        
        [When(@"I fill the Admin details")]
        public void WhenIFillTheAdminDetails(Table table)
        {
            var admin = table.CreateInstance<HRMAdminInfo>();

            // Fill the fields using the retrieved data
            OHRMPage.click_adminUserRole();
            OHRMPage.click_adminStatus();
            OHRMPage.Fill_adminEmployeeName(admin.EmployeeName);
            OHRMPage.Fill_adminUserName(admin.Username);
            OHRMPage.Fill_adminPass(admin.Password);
            OHRMPage.Fill_adminconfirmPass(admin.ConfirmPassword);
        }

        [When(@"I fill the job details")]
        public void WhenIFillTheJobDetails(Table table)
        {
            var job = table.CreateInstance<HRMJobInfo>();

            OHRMPage.Fill_Jobtitle(job.JobTitle);
        }

        //=============================================

        //Leave

        [Given(@"I click on Leave Tab")]
        public void GivenIClickOnLeaveTab()
        {
            OHRMPage.click_leaveTab();
        }
        [Given(@"I click on LeaveList menu")]
        public void GivenIClickOnLeaveListMenu()
        {
            OHRMPage.click_leavelistmenu();
        }
        [When(@"I select Leave Status")]
        public void WhenISelectLeaveStatus()
        {
            OHRMPage.click_showLeavewithStatus();
        }
        [When(@"I click on Search button")]
        public void WhenIClickOnSearchButton()
        {
            OHRMPage.click_leaveSearch();
        }
        [Then(@"I check the result")]
        public void ThenICheckTheResult()
        {

            OHRMPage.GetText_leaveNoResultFound();
        }
        [When(@"I select JobTitle")]
        public void WhenISelectJobTitle()
        {

            OHRMPage.click_job();

        }
        [When(@"I click on AddJob button")]
        public void WhenIClickOnAddJobButton()
        {
            Thread.Sleep(3000);
            OHRMPage.click_addJob();
        }

        [Then(@"I should see the new job ""([^""]*)"" is created")]
        public void ThenIShouldSeeTheNewJobIsCreated(string expected)
        {
            Thread.Sleep(5000);
            string actual=OHRMPage.GetText_jobcreated();
            Assert.AreEqual(expected, actual);
        }


        
        
        [Given(@"I search the Employee details with ""([^""]*)""")]
        public void GivenISearchTheEmployeeDetailsWith(string vinayak)
        {
            OHRMPage.Search_empName(vinayak);
        }


        [Then(@"I check the employee result")]
        public void ThenICheckTheEmployeeResult()
        {
            string result=OHRMPage.GetText_found();
            
        }

        [Given(@"I click on Include section")]
        public void GivenIClickOnIncludeSection()
        {
            OHRMPage.click_currentpast();
        }
    }
}
