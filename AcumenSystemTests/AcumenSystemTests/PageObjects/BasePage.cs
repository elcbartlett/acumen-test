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
    public abstract class BasePage
    {
        private readonly IWebDriver _driver;

        public BasePage(IWebDriver driver)
        {
            _driver = driver;
        }

        protected void NavigateToMenuItem(string linkText)
        {
            var waitTenSeconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            var waitOneSecond = new WebDriverWait(_driver, TimeSpan.FromSeconds(1));

            var menuButton = _driver.FindElement(By.ClassName("main-menu-toggle"));

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

            waitTenSeconds.Until(
                ExpectedConditions.ElementToBeClickable(By.LinkText(linkText)));

            _driver.FindElement(By.LinkText(linkText)).Click();


        }

        public void VerifyPostCodeIs(string postCode)
        {
            Assert.IsTrue(
                _driver.FindElement(By.ClassName("contact-details--text"))
                       .FindElement(By.TagName("a"))
                       .Text.EndsWith(postCode + " UK"));
        }

        public void VerifyEmailAddressIs(string emailAddress)
        {
            var emailAddressLinks = _driver.FindElements(By.XPath(".//a[@title='Drop us an email']"));

            Assert.IsTrue(emailAddressLinks.Count > 0);

            foreach (var emailAddressLink in emailAddressLinks)
            {
                Assert.AreEqual("mailto:" + emailAddress, emailAddressLink.GetAttribute("href"));
            }
        }

        public void VerifyPhoneNumberIs(string phoneNumber)
        {
            var phoneNumberLinks = _driver.FindElements(By.XPath(".//a[@title='Give us a call']"));

            Assert.IsTrue(phoneNumberLinks.Count > 0);

            foreach (var phoneNumberLink in phoneNumberLinks)
            {
                Assert.AreEqual(
                    "tel:" + phoneNumber.Replace(" ", "%20"), 
                    phoneNumberLink.GetAttribute("href"));
            }
        }

        public HomePage Home()
        {
            NavigateToMenuItem("Home");

            CheckUrl(homeUrl);

            return new HomePage(_driver);
        }

        public HomePage WhatWeDo()
        {
            NavigateToMenuItem("What we do");

            CheckUrl(whatWeDoUrl);

            return new HomePage(_driver);
        }

        public ClientStoriesPage ClientStories()
        {
            NavigateToMenuItem("Client stories");
            return new ClientStoriesPage(_driver);
        }

        public OurApplicationsPage OurApplications()
        {
            NavigateToMenuItem("Our applications");
            return new OurApplicationsPage(_driver);
        }


        public JoinOurTeamPage JoinOurTeam()
        {
            NavigateToMenuItem("Join our team");
            return new JoinOurTeamPage(_driver);
        }

        public void VerifyMapDisplayed()
        {
            var mapLink = _driver.FindElement(By.XPath(".//a[@title='Find us']")).GetAttribute("href");

            Assert.IsTrue(mapLink.Contains("https://www.google.co.uk/maps/"));
        }

        public void VerifyLinkedInDisplayed()
        {
            var linkedInLink = _driver.FindElement(By.XPath(".//a[@title='Connect with us']")).GetAttribute("href");

            Assert.IsTrue(linkedInLink.Contains("https://www.linkedin.com/company/"));
        }

        public OurApplicationsPage OurAppsTile()
        {
            _driver.FindElement(By.XPath(".//a[@href='http://www.acumenci.com/our-apps']")).Click();

            return new OurApplicationsPage(_driver);
        }

        public ClientStoriesPage ClientStoriesTile()
        {
            _driver.FindElement(By.XPath(".//a[@href='http://www.acumenci.com/client-stories']")).Click();

            return new ClientStoriesPage(_driver);
        }

        public JoinOurTeamPage JoinOurTeamTile()
        {
            _driver.FindElement(By.XPath(".//a[@href='http://www.acumenci.com/joinourteam']")).Click();

            return new JoinOurTeamPage(_driver);
        }

        public HomePage WhatWeDoTile()
        {          
            _driver.FindElement(By.XPath(".//a[@href='http://www.acumenci.com/#what-we-do']")).Click();

            CheckUrl(whatWeDoUrl);

            return new HomePage(_driver);
        }

        public HomePage AcumenLogoLink()
        {
            _driver.FindElement(By.ClassName("site-home-link"));

            CheckUrl(homeUrl);

            return new HomePage(_driver);
        }

        protected const string whatWeDoUrl = "http://www.acumenci.com/#what-we-do";
        protected const string homeUrl = "http://www.acumenci.com";

        protected void CheckUrl(string url)
        {
            var waitForTenSeconds = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));

            waitForTenSeconds.Until(ExpectedConditions.UrlMatches(url));

        }

    }
}
