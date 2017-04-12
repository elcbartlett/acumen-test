using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumenSystemTests.PageObjects
{
    public class ContactUsPage
    {
        private readonly IWebDriver _driver;

        public ContactUsPage(IWebDriver driver)
        {
            _driver = driver;

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

            Assert.IsTrue(
                emailAddressLinks.Count > 0);


            foreach(var emailAddressLink in emailAddressLinks)
            {
                Assert.AreEqual("mailto:" + emailAddress, emailAddressLink.GetAttribute("href"));
            }

           
        }

        public void VerifyPhoneNumberIs(string phoneNumber)
        {
            var phoneNumberLinks = _driver.FindElements(By.XPath(".//a[@title='Give us a call']"));

            Assert.IsTrue(
                phoneNumberLinks.Count > 0);


            foreach (var phoneNumberLink in phoneNumberLinks)
            {
                Assert.AreEqual("tel:" + phoneNumber.Replace(" ","%20"), phoneNumberLink.GetAttribute("href"));
            }

        }
    }
}

