using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;

namespace mantis_tests
{
    public class RegistrationHelper : HelperBase
    {
        public RegistrationHelper(ApplicationManager manager) : base(manager){}

        public void Register(AccountData account)
        {
            OpenMainPage();
            OpenRegistrationForm();
            FillRegistrationForm(account);
            SubmitRegistration();
        }
       

        void OpenRegistrationForm()
        {
            //driver.FindElement(By.LinkText("Зарегистрировать новую учётную запись")).Click();
            driver.FindElement(By.XPath("//a[contains(@href, 'signup_page.php')]")).Click();

        }

        void SubmitRegistration()
        {
            driver.FindElement(By.XPath("//*[@type='submit']")).Click();
        }

        void FillRegistrationForm(AccountData account)
        {
            driver.FindElement(By.Name("username")).SendKeys(account.Name);
            driver.FindElement(By.Name("email")).SendKeys(account.Email);
        }

        void OpenMainPage()
        {
            manager.Driver.Url = "http://localhost/mantisbt-2.25.4/login_page.php";
        }
    }
}
