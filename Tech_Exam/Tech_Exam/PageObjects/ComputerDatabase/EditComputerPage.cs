using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using Tech_Exam.Utilities;

namespace Tech_Exam.PageObjects.ComputerDatabase
{
    class EditComputerPage
    {
        CompDatabase_Objects compDbObj = new CompDatabase_Objects();

        private readonly IWebDriver driver;

        //Computer Database Edit Computer Page
        public EditComputerPage(IWebDriver driver)
        {
            this.driver = driver;
        }
        /* Page Elements for Edit Computer Page
         * 
         */
        //Link to HomePage
        private IWebElement LinktoHome
        {
            get
            {
                return this.driver.FindElement(By.XPath(compDbObj.lnkHome));
            }
        }
        //Edit a Computer Text
        private IWebElement EditComputerText
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
        //Discontinued Date Text Box
        private IWebElement DiscontinuedDateTextBox
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.txtDiscDate));
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
        //Save Computer Button
        private IWebElement SaveComputerBtn
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
        //Delete Computer Button
        private IWebElement DeleteComputerBtn
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.btnDelete));
            }
        }
        /* Page Methods for Add a Computer
         * 
         */
        //Edit a Computer is Displayed
        public Boolean EditComputerTextIsDisplayed(String editComputerText)
        {
            return String.Equals(EditComputerText.Text, editComputerText);
        }
        //Computer Name is Displayed
        public Boolean ComputerNameIsDisplayed(String editComputerText)
        {
            String computerName = ComputerNameTextBox.GetAttribute("value");
            Console.WriteLine(computerName);
            return String.Equals(computerName, editComputerText);
        }
        //Edit Text to Computer Name Text Box
        public void EditComputerNameText(String computerNameText)
        {
            ComputerNameTextBox.Clear();
            ComputerNameTextBox.SendKeys(computerNameText);
            return;
        }
        //Edit Text to Introduced Date Text Box
        public void EditIntroducedDateText(String introducedDateText)
        {
            IntroducedDateTextBox.Clear(); 
            IntroducedDateTextBox.SendKeys(introducedDateText);
            return;
        }
        //Edit Text to Discontinued Date Text Box
        public void EditDiscontinuedDateText(String discontinuedDateText)
        {
            DiscontinuedDateTextBox.Clear();
            DiscontinuedDateTextBox.SendKeys(discontinuedDateText);
            return;
        }
        //Edit Company From Dropdown
        public void SelectCompanyDropdown(String company)
        {
            SelectElement oSelect = new SelectElement(CompanyDropdown);
            oSelect.SelectByText(company);
            return;
        }
        //Click Save This Computer Button
        public void ClickSaveComputerBtn()
        {
            SaveComputerBtn.Click();
            return;
        }
        //Click Cancel Button
        public void ClickCancelBtn()
        {
            CancelBtn.Click();
            return;
        }
        //Click Delete This Computer Button
        public void ClickDeleteComputerBtn()
        {
            DeleteComputerBtn.Click();
            return;
        }
    }
}
