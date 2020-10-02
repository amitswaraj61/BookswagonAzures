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
   public class SearchHomePage
    {
        /// <summary>
        /// create IWebDriver
        /// </summary>
        public IWebDriver driver;

        /// <summary>
        /// create SearchHomePage constructor
        /// </summary>
        /// <param name="driver"></param>
        [System.Obsolete]
        public SearchHomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//div[1]//div[4]//div[5]//a[1]//input[1]")]
        public IWebElement BuyNowButton;

        [FindsBy(How = How.XPath, Using = "//html//body//div//div//div//div//div//iframe")]
        public IWebElement frame;

        [FindsBy(How = How.XPath, Using = "//body/form/div/div/div/div/div/table/tbody/tr/td/input[1]")]
        public IWebElement PlaceOrder;

        /// <summary>
        /// create Place order book method
        /// </summary>
        public void PlaceOrderBook()
        {
            BuyNowButton.Click();
            Thread.Sleep(2000);
            driver.SwitchTo().Frame(frame);
            Thread.Sleep(2000);
            PlaceOrder.Click();
            Thread.Sleep(2000);
        }
    }
}
