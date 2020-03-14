using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Tech_Exam.Utilities;

namespace Tech_Exam.PageObjects.JavaScript
{
    class JsAlertBox
    {

        private readonly IWebDriver driver;

        //Java Script Alert Home Page
        public JsAlertBox(IWebDriver driver)
        {
            this.driver = driver;
        }

        /* Checks Message
         * 
         */

       //Switch to alert box to the get the message
        public Boolean CheckJsAlertMsg(string alertMsg)
        {
            IAlert jsAlert = driver.SwitchTo().Alert();
            String alertText = jsAlert.Text;
            return String.Equals(alertText, alertMsg);          
        }

        //Accepting the alerbox 
        public void AcceptAlertBox()
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.Accept();
        }

        //Input text in the alertbox
        public void InputTextInAlertBox(string value)
        {
            IAlert alert = driver.SwitchTo().Alert();
            alert.SendKeys(value);
        }
    }
}
