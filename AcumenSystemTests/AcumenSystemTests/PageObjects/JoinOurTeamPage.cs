using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumenSystemTests.PageObjects
{
    public class JoinOurTeamPage : BasePage
    {
        private readonly IWebDriver _driver;

        public JoinOurTeamPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;

            var waitForTenSeconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            waitForTenSeconds.Until(ExpectedConditions.TitleContains("Join our team – acumen"));

        }

        public void VerifyIncludedJobRoleIs(string jobRole)
        {
            var jobRoleHeadings = _driver.FindElements(By.ClassName("section-heading"));

            Assert.IsTrue(jobRoleHeadings.Count > 0);

            foreach (var jobRoleHeading in jobRoleHeadings)
            {
                if (jobRoleHeading.Text.Contains(jobRole))
                {
                    return;
                }
            }

            Assert.Fail("Could not find job role " + jobRole);
        }

        public void VerifyApplyEmailAddressIs(string emailAddress)
        {
            var emailAddressLinks = _driver.FindElements(By.XPath(".//a[@title='Email Acumen']"));

            Assert.IsTrue(emailAddressLinks.Count > 0);

            foreach (var emailAddressLink in emailAddressLinks)
            {
                Assert.AreEqual("mailto:" + emailAddress, emailAddressLink.GetAttribute("href"));
            }
        }


    }
}
