using AcumenSystemTests.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumenSystemTests
{   
    [TestFixture]
    class ContactUsTests : TestFixtureBase
    {
        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I navigate to the Contact Us page " +
                    "Then I should see an accurate postcode “TW9 1HY” ")]
        public void AccurateAddress()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act
            ContactUsPage contactUsPage = homePage.Contact();

            //Assert
            contactUsPage.VerifyPostCodeIs("TW9 1HY");

        }

        [Test,
        Description("Given I am on the Contact Us page " +
                    "When I choose to get in touch by email " +
                    "Then I should see the correct " + 
                    "email address is pre-populated in my email client ")]
        public void AccurateEmail()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);
            

            //Act
            ContactUsPage contactUsPage = homePage.Contact();

            //Assert
            contactUsPage.VerifyEmailAddressIs("info@acumenci.com");

        }

        [Test,
        Description("Given I am on the Contact Us page " +
                    "When I choose to get in touch by phone " +
                    "Then I should see the correct " +
                    "telephone number is pre-populated in my phone app ")]
        public void AccurateTelephoneNumber()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);


            //Act
            ContactUsPage contactUsPage = homePage.Contact();

            //Assert
            contactUsPage.VerifyPhoneNumberIs("020 8334 0420");

        }
    }
}
