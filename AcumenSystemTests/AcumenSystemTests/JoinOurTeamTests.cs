using AcumenSystemTests.PageObjects;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcumenSystemTests
{
    class JoinOurTeamTests : TestFixtureBase
    {

        [Test,
        Description("Given I am on the Acumen “Join Our Team” page  " +
                    "When I iterate through the titles of current opportunities  " +
                    "Then I should see “tester” within at least one of them")]
        public void LocateJobRole()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act
            JoinOurTeamPage joinOurTeamPage = homePage.JoinOurTeam();

            //Assert
            joinOurTeamPage.VerifyIncludedJobRoleIs("tester");

        }

        [Test,
        Description("Given I am on the Acumen “Join Our Team” page  " +
                    "When I choose to apply by email " +
                    "Then I should see the correct " +
                    "email address is pre-populated in my email client ")]
        public void AccurateJobsEmail()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act
            JoinOurTeamPage joinOurTeamPage = homePage.JoinOurTeam();

            //Assert
            joinOurTeamPage.VerifyApplyEmailAddressIs("jobs@acumenci.com");
            
        }

        [Test,
        Description("Given I am on the Acumen “Join Our Team” page  " +
                    "When I click the Home link on the navigation menu  " +
                    "Then I shall return to the Home page")]
        public void ReturnToHomePage()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act
            JoinOurTeamPage joinOurTeamPage = homePage.JoinOurTeam();

            //Assert
            Assert.DoesNotThrow(() => homePage = joinOurTeamPage.Home());

        }

   
    }
}
