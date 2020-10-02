using BookswagonAzures.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookswagonAzures.BookswagonTest
{
    public class Test : Base
    {
        [Obsolete]
        [Test, Order(1)]
        public void ValidLogin()
        {
            Login login = new Login(driver);
            login.LoginToBookSwagaon(ConfigurationManager.AppSettings["email"], ConfigurationManager.AppSettings["password"]);
            string actualResult = driver.Url;
            string expectedResult = "https://www.bookswagon.com/myaccount.aspx";
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}