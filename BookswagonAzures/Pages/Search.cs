﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BookswagonAzures.Pages
{
   public class Search
    {
        /// <summary>
        /// create IWebDriver
        /// </summary>
        public IWebDriver driver;

        /// <summary>
        /// create Search constructor
        /// </summary>
        /// <param name="driver"></param>
        [System.Obsolete]
        public Search(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_TopSearch1_txtSearch")]
        public IWebElement SearchBox;

        [FindsBy(How = How.XPath, Using = "//body/form/div/div/div/div/div/div/div[2]/input[1]")]
        public IWebElement SearchButton;

        /// <summary>
        /// create Search Book method
        /// </summary>
        public void SearchBook()
        {
            SearchBox.Click();
            Thread.Sleep(2000);
            SearchBox.SendKeys("mahabharata");
            Thread.Sleep(2000);
            SearchButton.Click();
            Thread.Sleep(2000);
        }
    }
}
