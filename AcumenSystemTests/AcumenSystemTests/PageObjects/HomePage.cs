using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AcumenSystemTests.PageObjects
{
    public class HomePage
    {
        private readonly IWebDriver _driver;

        public HomePage(IWebDriver driver) 
        {
            _driver = driver;

        }

        public ContactUsPage Contact()
        {
            var waitTenSeconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var waitOneSecond = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));

            var menuIconClass = "main-menu-toggle";

            var menuList = _driver.FindElement(By.Id("primary-menu"));
            var menuButton = _driver.FindElement(By.ClassName(menuIconClass));

            //If you click the burger button too early then the menu does not appear
            //Re-try mechanism is more reliable then sleep
            while (true)
            {
                menuButton.Click();
                try
                {
                    waitOneSecond.Until(ExpectedConditions.ElementIsVisible(By.Id("primary-menu")));
                    break;
                }
                catch
                {
                }
            }

            var linkTextContactButton = "Contact";

            waitTenSeconds.Until(
                ExpectedConditions.ElementToBeClickable(By.LinkText(linkTextContactButton)));

            _driver.FindElement(By.LinkText(linkTextContactButton)).Click();

            return new ContactUsPage(_driver);
        }
    }
}
