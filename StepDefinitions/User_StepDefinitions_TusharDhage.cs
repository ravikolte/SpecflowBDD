using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectModel_Specflow.ConstantHelpers;
using PageObjectModel_Specflow.Pages;
using System;
using TechTalk.SpecFlow;

namespace PageObjectModel_Specflow.StepDefinitions
{
    [Binding]
    public sealed class User_StepDefinitions_TusharDhage
    {
        private IWebDriver driver;
        UserManagement_TusharDhage userManagement;


        public User_StepDefinitions_TusharDhage(IWebDriver driver)
        {
            this.driver = driver;
            userManagement = new UserManagement_TusharDhage(driver);
        }


        [When(@"the user clicks on the Admin tab/option")]
        public void WhentheuserclicksontheAdmintaboption()
        {
            userManagement.Click_Admin();
        }

        [Then(@"the Admin page is displayed")]
        public void ThentheAdminpageisdisplayed()
        {
            userManagement.verify_Admin_Screen();
        }

        [When(@"the user clicks on the option to create a new user")]
        public void Whentheuserclicksontheoptiontocreateanewuser()
        {
            userManagement.select_User();
        }

        [Then(@"the user is taken to the user creation page")]
        public void Thentheuseristakentotheusercreationpage()
        {
            userManagement.verify_Add_User_Screen().tap_Add_User().verify_User_Creation_Screen();
        }

        [Then(@"the user add username ""(.*)"" password ""(.*)"" and then confirm password ""(.*)""")]
        public void ThenTheUserAddUsernamePasswordAndThenConfirmPassword(string username0, string password1, string p2, Table table)
        {
            userManagement.create_User(table);
        }

        [When(@"the user fills firstname ""(.*)"" middlename ""(.*)"" and lastname ""(.*)"" under Add Employee")]
        public void WhentheuserfillsfirstnamemiddlenameandlastnameunderAddEmployee(string args1, string args2, string args3, Table table)
        {

            userManagement.add_Employee_Info(table);
        }


        [Then(@"fill jobTitle ""(.*)"" jobDiscription ""(.*)"" and jobNote ""(.*)"" details on the Job Title page")]
        public void ThenfilljobTitlejobDiscriptionandjobNotedetailsontheJobTitlepage(string args1, string args2, string args3, Table table)
        {
            userManagement.tap_Add_User().fill_Job_Title_Form(table);
        }


        [Then(@"clicks on the Save option")]
        public void ThenclicksontheSaveoption()
        {
            userManagement.tap_Save_Button();
        }

        [Then(@"a success popup is displayed")]
        public void Thenasuccesspopupisdisplayed()
        {
            userManagement.VerifySuccessMessage();
        }

        [When(@"the page is refreshed")]
        public void Whenthepageisrefreshed()
        {
            userManagement.RefreshScreen();
        }

        [Then(@"a new user ""(.*)"" should be listed under the System Users page")]
        public void ThenanewusershouldbelistedundertheSystemUserspage(string username)
        {
            userManagement.Verify_Created_User(username);
        }


        [When(@"the user clicks on the PIM tab/option")]
        public void WhentheuserclicksonthePIMtaboption()
        {
            userManagement.tapPIM();
        }

        [Then(@"the user clicks on the add employee button")]
        public void Thentheuserclicksontheaddemployeebutton()
        {
            userManagement.tap_Add_Employee();
        }

        [Given(@"the user is on the Add Employee page")]
        public void GiventheuserisontheAddEmployeepage()
        {
            userManagement.verify_Employee_Screen();
        }

        [Then(@"enables the Create login details option")]
        public void ThenenablestheCreatelogindetailsoption()
        {
            userManagement.tapOnLoginToggleButton();
        }

        [Then(@"the user fills username ""(.*)"" password ""(.*)"" and then confirm password ""(.*)""")]
        public void Thentheuserfillsusernamepasswordandthenconfirmpassword(string args1, string args2, string args3, Table table)
        {
            userManagement.emp_Login(table);
        }


        [Then(@"clicks the Save button")]
        public void ThenclickstheSavebutton()
        {
            userManagement.tap_Save_Button();
        }


        [Then(@"a new employee ""(.*)"" should be created and listed in the Employee List page")]
        public void ThenanewemployeeshouldbecreatedandlistedintheEmployeeListpage(string args1)
        {
            userManagement.verifyEmployeeList(args1);
        }


        [Then(@"Search employee ""(.*)"" should be created and listed in the Employee List page")]
        public void ThenSearchemployeeshouldbecreatedandlistedintheEmployeeListpage(string args1)
        {
            userManagement.search_Employee();
        }



        [Given(@"click on the Leave tab in the left navigation")]
        public void GivenclickontheLeavetabintheleftnavigation()
        {
            userManagement.tap_Leave_Menu();
        }


        [Then(@"select the Job Title option from the Job dropdown")]
        public void ThenselecttheJobTitleoptionfromtheJobdropdown()
        {
            userManagement.tap_Job_Titles();
        }

        [Then(@"the newly created job title will be visible on the Job Title page after the page is refreshed.")]
        public void ThenthenewlycreatedjobtitlewillbevisibleontheJobTitlepageafterthepageisrefreshed()
        {
            userManagement.scrollToText();
        }


        [Then(@"I click on Employee List option")]
        public void ThenIclickonEmployeeListoption()
        {
            userManagement.click_EmployeeList();
        }

        // [Then(@"I fill in the required details of the Employee")]
        // public void ThenIfillintherequireddetailsoftheEmployee()
        // {
        //     userManagement.search_Employee();
        // }


        [Then(@"Search employee should be created and listed in the Employee List page")]
        public void ThenSearchemployeeshouldbecreatedandlistedintheEmployeeListpage()
        {
            userManagement.search_Employee();
        }


        [When(@"the required details will be displayed under Employee List page")]
        public void WhentherequireddetailswillbedisplayedunderEmployeeListpage()
        {
            userManagement.search_Record();
        }

        [Then(@"it will route to Myinfo page")]
        public void ThenitwillroutetoMyinfopage()
        {
            userManagement.verify_Personal_Info().delete_User();
        }



    }
}