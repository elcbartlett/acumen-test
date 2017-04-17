using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AcumenSystemTests.PageObjects
{
    public class OurApplicationsPage : BasePage
    {
        private readonly IWebDriver _driver;

        public OurApplicationsPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

            var waitForTenSeconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            waitForTenSeconds.Until(ExpectedConditions.TitleContains("Our applications – acumen"));

        }
    }
}
