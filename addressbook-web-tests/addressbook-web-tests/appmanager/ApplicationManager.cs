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
    public class ApplicationManager
    {
        protected LoginHelper loginHelper;
        protected NavigationHelper navigationHelper;
        protected GroupHelper groupHelper;

        protected IWebDriver driver;
        protected string baseURL;

        public ApplicationManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\MozillaESR\firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);

            baseURL = "http://localhost/";
            loginHelper = new LoginHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            groupHelper = new GroupHelper(this);
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
            }

            set
            {

            }
        }

        public void Stop()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }

        public LoginHelper Auth
        {
            get
            {
                return loginHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigationHelper;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

        
    }
}
