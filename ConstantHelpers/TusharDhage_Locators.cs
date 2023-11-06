using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;


namespace PageObjectModel_Specflow.ConstantHelpers

{
  public class TusharDhage_Locators
  {
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
    public static By userName = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/form[1]/div[1]/div[1]/div[4]/div[1]/div[2]/input[1]");
    public static By passWord = By.XPath("//input[@type='password']");
    public static By confirmPassword = By.XPath("//div[@class='oxd-grid-item oxd-grid-item--gutters']//div[@class='oxd-input-group oxd-input-field-bottom-space']//div//input[@type='password']");
    public static By saveButton = By.XPath("//button[@type='submit']");
    public static By statusDropDown = By.XPath("//div[contains(text(),'-- Select --')]");
    public static By successMsg = By.XPath("//p[@class='oxd-text oxd-text--p oxd-text--toast-message oxd-toast-content-text']");
    public static By searchUsername = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/div[2]/form[1]/div[1]/div[1]/div[1]/div[1]/div[2]/input[1]");
    public static By searchButton = By.XPath("//button[@type='submit']");
    public static By validateUsername = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[2]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]");
    public static By pimMenu = By.LinkText("PIM");
    public static By addEmployee = By.LinkText("Add Employee");
    public static By firstName = By.XPath("//input[@name='firstName']");
    public static By middleName = By.XPath("//input[@name='middleName']");
    public static By lastName = By.XPath("//input[@name='lastName']");
    public static By userNameField = By.XPath("//body/div[@id='app']/div[@class='oxd-layout']/div[@class='oxd-layout-container']/div[@class='oxd-layout-context']/div[@class='orangehrm-background-container']/div[@class='orangehrm-card-container']/form[@class='oxd-form']/div[@class='orangehrm-employee-container']/div[@class='orangehrm-employee-form']/div[@class='oxd-form-row']/div[1]/div[1]/div[1]/div[2]/input[1]");
    public static By empList = By.LinkText("Employee List");
    public static By empUserName = By.XPath("//h6[@class='oxd-text oxd-text--h6 --strong']");
    public static By employeeName = By.XPath("//div[@class='oxd-autocomplete-text-input oxd-autocomplete-text-input--active']//input[@placeholder='Type for hints...']");
    public static By deleteUser = By.XPath("//div[@class='oxd-table-card-cell-checkbox']//i[@class='oxd-icon bi-check oxd-checkbox-input-icon']");
    public static By loginToggleButton = By.XPath("//span[@class= 'oxd-switch-input oxd-switch-input--active --label-right']");
    public static By deletePopup = By.XPath("//button[normalize-space()='Yes, Delete']");
    public static By leaveMenu = By.LinkText("Leave");
    public static By deleteEmployee = By.XPath("//i[@class='oxd-icon bi-trash']");
    public static By jobtitle = By.XPath("/html[1]/body[1]/div[1]/div[1]/div[2]/div[2]/div[1]/div[1]/form[1]/div[1]/div[1]/div[2]/input[1]");
    public static By jobDescription = By.XPath("//textarea[@placeholder='Type description here']");
    public static By addNote = By.XPath("//textarea[@placeholder='Add note']");
    public static By jobTitle = By.XPath("//li[@class='--active oxd-topbar-body-nav-tab --parent']//li[1]");
    public static By jobTitleCreated = By.XPath("//div[@role='rowgroup']//div[1]//div[1]//div[2]");
    public static By jobMenu = By.XPath("//span[normalize-space()='Job']");
    public static By searchJob = By.XPath("//div[normalize-space()='QA Automation']");
    public static By deleteJob = By.XPath("//div[normalize-space()='QA Automation']/following-sibling::*//i[@class='oxd-icon bi-trash']");

    public static By recordSearch = By.XPath("//div[@role='rowgroup']//div[1]//div[1]//div[3]//div[1]");
    public static By personalDetails = By.XPath("//h6[normalize-space()='Personal Details']");
  }
}
