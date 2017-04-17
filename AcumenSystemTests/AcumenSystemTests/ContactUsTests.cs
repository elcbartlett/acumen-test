using AcumenSystemTests.PageObjects;
using NUnit.Framework;

namespace AcumenSystemTests
{
    [TestFixture]
    class ContactUsTests : TestFixtureBase
    {
        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I examine the office address at the bottom of the page " +
                    "Then I should see an accurate postcode “TW9 1HY” ")]
        public void AccurateAddress()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            homePage.VerifyPostCodeIs("TW9 1HY");

        }

        [Test,
        Description("Given I am on the Acument home page " +
                    "When I choose to get in touch by email " +
                    "Then I should see the correct " + 
                    "email address is pre-populated in my email client ")]
        public void AccurateInfoEmail()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);
            
            //Act / Assert
            homePage.VerifyEmailAddressIs("info@acumenci.com");

        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I choose to get in touch by phone " +
                    "Then I should see the correct " +
                    "telephone number is pre-populated in my phone app ")]
        public void AccurateTelephoneNumber()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);
            
            //Act / Assert
            homePage.VerifyPhoneNumberIs("020 8334 0420");

        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I choose to view the location of Acumen " +
                    "Then a map is displayed")]
        public void VerifyMap()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            homePage.VerifyMapDisplayed();
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I choose to view their LinkedIn " +
                    "Then their LinkedIn profile is displayed")]
        public void VerifyLinkedIn()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            homePage.VerifyLinkedInDisplayed();
        }
    }
}
