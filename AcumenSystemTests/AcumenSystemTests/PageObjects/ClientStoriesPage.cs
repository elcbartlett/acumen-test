using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumenSystemTests.PageObjects
{
    public class ClientStoriesPage : BasePage
    {
        private readonly IWebDriver _driver;

        public ClientStoriesPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

            var waitForTenSeconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            waitForTenSeconds.Until(ExpectedConditions.TitleContains("Client stories – acumen"));

        }


    }
}
