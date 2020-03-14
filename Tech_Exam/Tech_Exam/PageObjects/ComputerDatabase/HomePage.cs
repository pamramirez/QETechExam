using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using Tech_Exam.Utilities;

namespace Tech_Exam.PageObjects.ComputerDatabase
{
    class HomePage
    {
        CompDatabase_Objects compDbObj = new CompDatabase_Objects();
        private readonly IWebDriver driver;
        
        //Computer Database Home Page
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
        }

        /* Page Elements for HomePage
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
        //Total Computers Found Text
        private IWebElement TotalText
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.hdrMessage));
            }
        }
        //Filter By Text Box
        private IWebElement SearchBox
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.txtSearchName));
            }
        }
        //Filter by Name Button
        private IWebElement SearchBtn
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.btnFilterName));
            }
        }
        //Add a new Computer Button
        private IWebElement AddComputerBtn
        {
            get
            {
                return this.driver.FindElement(By.Id(compDbObj.btnAddNewComp));
            }
        }
        //Search Results Table
        private IWebElement ResultsTable
        {
            get
            {
                return this.driver.FindElement(By.ClassName(compDbObj.tblResults));
            }
        }
        //Pagination Previous Button
        private IWebElement PreviousBtn
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.btnPrevious));
            }
        }
        //Pagination Next Button
        private IWebElement NextBtn
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.btnNext));
            }
        }
        //Message Text
        private IWebElement MessageText
        {
            get
            {
                return this.driver.FindElement(By.CssSelector(compDbObj.hdrMessage));
            }
        }
        /* Page Methods for HomePage
         * 
         */
        //Link to Home is Displayed
        public string GoToComputerDatabasePage(string url)
        {
            return this.driver.Url = url;
        }
        public Boolean LinkToHomeIsDisplayed()
        {
            return LinktoHome.Displayed;
        }
        //Total Number of Computers is Displayed
        public Boolean TotalIsDisplayed()
        {
            return TotalText.Displayed;
        }
        //Get Total Number of Computers Text
        public string GetTotalText()
        {
            return TotalText.Text;
        }
        //Click Link to HomePage
        public void ClickLinktoHome()
        {
            LinktoHome.Click();
            return;
        }
        //Add Text to Filter By Text Box
        public void AddFilterText(String filterText)
        {
            SearchBox.SendKeys(filterText);
            return;
        }
        //Click Filter by Name Button
        public void ClickSearchBtn()
        {
            SearchBtn.Click();
            return;
        }
        //Results Table Is Displayed
        public Boolean ResultsTableIsDisplayed()
        {
            return ResultsTable.Displayed;
        }
        //Computer Is Displayed
        public Boolean ComputerIsDisplayed(string computerName)
        {
            IWebElement computer = driver.FindElement(By.LinkText(computerName));
            Boolean isDisplayed = computer.Displayed;
            computer.Click();
            return isDisplayed;
        }
        //Click Add a New Computer Button
        public void ClickAddComputerBtn()
        {
            AddComputerBtn.Click();
            return;
        }
        //Click Previous Button
        public void ClickPreviousBtn()
        {
            PreviousBtn.Click();
            return;
        }
        //Click Next Button
        public void ClickNextBtn()
        {
            NextBtn.Click();
            return;
        }
        //Correct Message is Displayed
        public Boolean MessageIsDisplayed(String messageText)
        {
            String message = MessageText.Text;
            Console.WriteLine(message);
            return String.Equals(message, messageText);
        }
    }
}
