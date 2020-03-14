using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Tech_Exam.PageObjects.ComputerDatabase;
using Tech_Exam.Utilities;

namespace Tech_Exam
{
    [Binding]
    class ComputerDatabaseSteps
    {
        CompDatabase_Objects compDbObj = new CompDatabase_Objects();
        private readonly IWebDriver driver;

        public ComputerDatabaseSteps(IWebDriver driver)
        {
            this.driver = driver;
        }
        [Given(@"User access the computer database site")]
        public void GivenUserAccessTheLinkToComputerDatabase()
        {
            HomePage homePage = new HomePage(driver);
            homePage.GoToComputerDatabasePage(compDbObj.computer_database_url);
            homePage.LinkToHomeIsDisplayed();
        }

        [When(@"User clicks the Add a new computer button")]
        public void WhenUserClicksTheAddANewComputerButton()
        {
            HomePage homePage = new HomePage(driver);
            homePage.ClickAddComputerBtn();
            //Checks that add computer is displayed
            AddComputerPage addComputerPage = new AddComputerPage(driver);
            addComputerPage.AddComputerTextIsDisplayed("Add a computer");
        }

        [When(@"fill all the fields in form (.*), (.*), (.*), (.*)")]
        public void WhenFillAllTheFieldsInForm(String Computername, String IntroducedDate, String DiscontDate, String Company)
        {
            //Input Details in the following text
            AddComputerPage addComputerPage = new AddComputerPage(driver);
            addComputerPage.AddComputerNameText(Computername);
            addComputerPage.AddIntroducedDateText(IntroducedDate);
            addComputerPage.AddDiscontinuedDateText(DiscontDate);
            addComputerPage.SelectCompanyDropdown(Company);
            //Click the Create this computer button
            addComputerPage.ClickCreateComputerBtn();
        }

        [When(@"User searches for an existing (.*)")]
        public void WhenUserSearchForAnAAA_ACComputer(String Computername)
        {
            HomePage homePage = new HomePage(driver);
            homePage.LinkToHomeIsDisplayed();
            homePage.TotalIsDisplayed();
            Console.WriteLine(homePage.GetTotalText());

            homePage.AddFilterText(Computername);
            homePage.ClickSearchBtn();
            homePage.ResultsTableIsDisplayed();
            homePage.ComputerIsDisplayed(Computername);

            EditComputerPage editComputerPage = new EditComputerPage(driver);
            editComputerPage.EditComputerTextIsDisplayed("Edit computer");
        }

        [Then(@"User should be able to view the (.*)")]
        public void ThenUserShouldBeAbleToViewTheAAA_ACComputerName(String existing)
        {
            EditComputerPage editComputerPage = new EditComputerPage(driver);
            editComputerPage.ComputerNameIsDisplayed(existing);
        }

        [When(@"User updated the (.*), (.*), (.*), (.*) value")]
        public void WhenUserUpdatedTheNokiaValue(String Computername, String IntroducedDate, String DiscontDate, String Company)
        {
            EditComputerPage editComputerPage = new EditComputerPage(driver);
            editComputerPage.EditComputerNameText(Computername);
            editComputerPage.EditIntroducedDateText(IntroducedDate);
            editComputerPage.EditDiscontinuedDateText(DiscontDate);
            editComputerPage.SelectCompanyDropdown(Company);
            //Click the Create this computer button
            editComputerPage.ClickSaveComputerBtn();
        }

        [When(@"User delete an (.*) record")]
        public void WhenUserDeleteAnAAA_ACRecord(String Computername)
        {
            EditComputerPage editComputerPage = new EditComputerPage(driver);
            //Click Delete button
            editComputerPage.ClickDeleteComputerBtn();
        }

        [Then(@"User should see that the record has been deleted")]
        public void ThenUserShouldSeeThatTheRecordHasBeenDeletedWithDoneComputerHasBeenDeleted()
        {
            HomePage homePage = new HomePage(driver);
            homePage.MessageIsDisplayed("Done! Computer has been deleted");
        }

        [Then(@"User will not be able to add the record")]
        public void ThenUserWillNotBeAbleToAddTheRecord()
        {
            AddComputerPage addComputerPage = new AddComputerPage(driver);
            addComputerPage.IntroducedDateError("clearfix error");
            addComputerPage.DiscontinuedDateError("clearfix error");
        }

        [Then(@"User should see that the (.*) list has been (.*)")]
        public void ThenUserShouldSeeThatTheAAA_ACListHasBeenModified(String Computername, String modified)
        {
            HomePage homePage = new HomePage(driver);
            if (modified == "add")
            {
                homePage.MessageIsDisplayed("Done! Computer " + Computername + " has been created");
            }
            else if (modified == "update")
            {
                homePage.MessageIsDisplayed("Done! Computer " + Computername + " has been updated");
            }
            else if (modified == "delete")
            {
                homePage.MessageIsDisplayed("Done! Computer has been deleted");
            }
        }
    }
}

