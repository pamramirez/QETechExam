using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Tech_Exam.Utilities;

namespace Tech_Exam.PageObjects.JavaScript
{
    class JsHomePage
    {
        JSAlertPage_Objects alertpageobj = new JSAlertPage_Objects();

        private readonly IWebDriver driver;

        //Java Script Alert Home Page
        public JsHomePage(IWebDriver driver)
        {
            this.driver = driver;
        }
        
        /* Page Elements for Home Page
         * 
         */
        //Link to JavaScript Alert Page
        private IWebElement LinktoJsHome
        {
            get
            { 
                return this.driver.FindElement(By.CssSelector(alertpageobj.hdrJavaScript));
            }
        }

        //Click for JS Alert Button
        private IWebElement JsAlertBtn
        {
            get 
            {
                return this.driver.FindElement(By.CssSelector(alertpageobj.btnJSAlert));
            }
        }

        //Click for JS Confirm Button
        private IWebElement JsConfirmBtn
        {
            get 
            {
                return this.driver.FindElement(By.CssSelector(alertpageobj.btnJSConfirm));
            }
        }

        //Click for JS Prompt Button
        private IWebElement JsPromptBtn
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(alertpageobj.btnJSPrompt));
            }
        }

        //Result Message
        private IWebElement ResultsMsgHdr
        {
            get
            {
                return this.driver.FindElement(By.Id(alertpageobj.hdrResultMsg));
            }
        }

        /* Page Methods for HomePage
        * 
        */
        public string GoToJavaScriptAlertsPage(string url)
        {
            return this.driver.Url = url;
        }
        public Boolean LinkToJsHomeIsDisplayed()
        {
            return LinktoJsHome.Displayed;
        }

        public void JsAlertBtnToBeClicked(String alert)
        {
            if (alert == "JSAlert")
            {
                JsAlertBtn.Click();
            }
            else if (alert == "JSConfirm")
            {
                JsConfirmBtn.Click();
            }
            else if (alert == "JSPrompt")
            {
                JsPromptBtn.Click();
            }
        }


        //Get Total Number of Computers Text
        public string GetResultMessageText()
        {
            return ResultsMsgHdr.Text;
        }

        //Check Results message
        public Boolean CheckResultMsg(string resultMsg, string successMsg)
        {
            
            return String.Equals(resultMsg, successMsg);
        }

    }

}
