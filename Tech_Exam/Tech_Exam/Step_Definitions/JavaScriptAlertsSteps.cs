using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Tech_Exam.PageObjects.JavaScript;
using Tech_Exam.Utilities;

namespace Tech_Exam.Step_Definitions
{
    [Binding]
    class JavaScriptAlertsSteps
    {
        JSAlertPage_Objects alertpageobj = new JSAlertPage_Objects();

        private readonly IWebDriver driver;

        public JavaScriptAlertsSteps(IWebDriver driver)
        {
            this.driver = driver;
        }

        [Given(@"User access the JavaScript alert site")]
        public void GivenUserAccessTheJavaScriptAlertSite()
        {

            
            JsHomePage homepage = new JsHomePage(driver);
            homepage.GoToJavaScriptAlertsPage(alertpageobj.urlJS);
            homepage.LinkToJsHomeIsDisplayed();
        }

        [When(@"User clicks the JS (.*)")]
        public void WhenUserClicksTheJSAlert(String alert)
        {
            JsHomePage homepage = new JsHomePage(driver);
            homepage.JsAlertBtnToBeClicked(alert);
        }

        [When(@"User checks the (.*) message")]
        public void WhenUserChecksTheAlertMessage(string alert)
        {
            JsAlertBox alertbox = new JsAlertBox(driver);
            String alertMsg = string.Empty;

            if (alert == "JSAlert")
            {
                alertMsg = "I am a JS Alert";
            }
            else if (alert == "JSConfirm")
            {
                alertMsg = "I am a JS Confirm";
            }
            else if (alert == "JSPrompt")
            {
                alertMsg = "I am a JS prompt";
            }

            alertbox.CheckJsAlertMsg(alertMsg);
        }


        [When(@"User clicks the Ok button in the alert")]
        public void WhenUserClicksTheOkButtonInTheAlert()
        {
            JsAlertBox alertbox = new JsAlertBox(driver);
            alertbox.AcceptAlertBox();
        }

        [Then(@"User should see a successful message for (.*) and (.*) is displayed")]
        public void ThenUserShouldSeeAMessageIsDisplayed(string alert, string value)
        {
            JsHomePage homepage = new JsHomePage(driver);
            String resultMsg = homepage.GetResultMessageText();

            String successMsg = string.Empty;
            if (alert == "JSAlert")
            {
                successMsg = "You successfuly clicked an alert";
            }
            else if (alert == "JSConfirm")
            {
                successMsg = "You clicked: " + value;
            }
            else if (alert == "JSPrompt")
            {
                successMsg = "You entered: " + value;
            }

            homepage.CheckResultMsg(resultMsg, successMsg);
        }

        [When(@"User sends (.*) to the alert box")]
        public void WhenUserSendsToTheAlertBox(string value)
        {
            JsAlertBox alertbox = new JsAlertBox(driver);
            alertbox.InputTextInAlertBox(value);
        }

        }
    }

