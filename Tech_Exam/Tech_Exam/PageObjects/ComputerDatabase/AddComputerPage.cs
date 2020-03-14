using System;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Tech_Exam.Utilities;

namespace Tech_Exam.PageObjects.ComputerDatabase
{
    class AddComputerPage
    {
        CompDatabase_Objects compDbObj = new CompDatabase_Objects();
        private readonly IWebDriver driver;

        //Computer Database Add a Computer Page
        public AddComputerPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /* Page Elements for Add a Computer Page
         * 
         */
        //Add a Computer Text
        private IWebElement AddComputerText
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.hdrMessage));
            }
        }
        //Computer Name Text Box
        private IWebElement ComputerNameTextBox
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.txtCompName));
            }
        }
        //Introduced Date Text Box
        private IWebElement IntroducedDateTextBox
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.txtIntroDate));
            }
        }
        //Introduced Date Div
        private IWebElement IntroducedDateDiv
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.txtFailIntroDate));
            }
        }
        //Discontinued Date Text Box
        private IWebElement DiscontinuedDateTextBox
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.txtDiscDate));
            }
        }
        //Discontinued Date Div
        private IWebElement DiscontinuedDateDiv
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.txtFailDiscoDate));
            }
        }
        //Company Dropdown
        private IWebElement CompanyDropdown
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.drpCompany));
            }
        }
        //Create This Computer Button
        private IWebElement CreateComputerBtn
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.btnSave));
            }
        }
        //Cancel Button
        private IWebElement CancelBtn
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.btnCancel));
            }
        }
        //Create Message Text
        private IWebElement DeleteMessageText
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.hdrMessage));
            }
        }
        /* Page Methods for Add a Computer
         * 
         */
        //Add a Computer is Displayed
        public Boolean AddComputerTextIsDisplayed(String addComputerText)
        {
            return String.Equals(AddComputerText.Text, addComputerText);
        }
        //Add Text to Computer Name Text Box
        public void AddComputerNameText(String computerNameText)
        {
            ComputerNameTextBox.SendKeys(computerNameText);
            return;
        }
        //Add Text to Introduced Date Text Box
        public void AddIntroducedDateText(String introducedDateText)
        {
            IntroducedDateTextBox.SendKeys(introducedDateText);
            return;
        }
        //Add Text to Discontinued Date Text Box
        public void AddDiscontinuedDateText(String discontinuedDateText)
        {
            DiscontinuedDateTextBox.SendKeys(discontinuedDateText);
            return;
        }
        //Select Company From Dropdown
        public void SelectCompanyDropdown(String company)
        {
            SelectElement oSelect = new SelectElement(CompanyDropdown);
            oSelect.SelectByText(company);
            return;
        }
        //Click Create This Computer Button
        public void ClickCreateComputerBtn()
        {
            CreateComputerBtn.Click();
            return;
        }
        //Click Cancel Button
        public void ClickCancelBtn()
        {
            CancelBtn.Click();
            return;
        }
        //Introduced Date has an Error
        public Boolean IntroducedDateError(String error)
        {
            String introdate = IntroducedDateDiv.GetAttribute("class");
            Console.WriteLine(introdate);
            return String.Equals(introdate, error);
        }
        //Discontinued Date has an Error
        public Boolean DiscontinuedDateError(String error)
        {
            String discodate = DiscontinuedDateDiv.GetAttribute("class");
            Console.WriteLine(discodate);
            return String.Equals(discodate, error);
        }
    }
}
