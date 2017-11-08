using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    public class NavigationHelper : HelperBase
    {
        protected string baseUrl;

        public NavigationHelper(IWebDriver driver, string baseUrl) : base(driver)
        {
            this.baseUrl = baseUrl;
        }

        public void GoToHomePage()
        {
            driver.Navigate().GoToUrl(baseUrl + "addressbook/");
        }

        public void GoToGroupsPage()
        {
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
