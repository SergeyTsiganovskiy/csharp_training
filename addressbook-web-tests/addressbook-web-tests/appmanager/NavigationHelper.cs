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

        public NavigationHelper(ApplicationManager manager, string baseUrl) : base(manager)
        {
            this.baseUrl = baseUrl;
        }

        public void GoToHomePage()
        {
            if (driver.Url == baseUrl + "addressbook/")
            {
                return;
            }
            driver.Navigate().GoToUrl(baseUrl + "addressbook/");
        }

        public void GoToGroupsPage()
        {
            if (driver.Url == baseUrl + "addressbook/group.php"
                && IsElementPresent(By.Name("new")))
              {
                return;
              }
            driver.FindElement(By.LinkText("groups")).Click();
        }
    }
}
