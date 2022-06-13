using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace mantis_tests
{
    public class NavigationHelper : HelperBase
    {
        private readonly string baseURL;
        private readonly string mantis_bv;

        public NavigationHelper(ApplicationManager manager, string baseURL, string mantis_bv) : base(manager)
        {
            this.baseURL = baseURL;
            this.mantis_bv = mantis_bv;
        }
        public NavigationHelper GoToHomePage()
        {
            if (driver.Url == baseURL)
            {
                return this;
            }
            driver.Navigate().GoToUrl(baseURL);
            return this;
        }
        public NavigationHelper GoToManageOverviewPage()
        {
            driver.FindElement(By.XPath($"//a[@href='/mantisbt-{mantis_bv}/manage_overview_page.php']")).Click();

            return this;
        }
        public NavigationHelper GoToProjectControlPage()
        {
            driver.FindElement(By.XPath($"//a[@href='/mantisbt-{mantis_bv}/manage_proj_page.php']")).Click();

            return this;
        }
    }
}