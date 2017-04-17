using AcumenSystemTests.PageObjects;
using NUnit.Framework;

namespace AcumenSystemTests
{
    [TestFixture]
    class HomePageTests : TestFixtureBase
    {
        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Acumen logo " +
                    "Then I stay on the Home page")]
        public void VerifyAcumenLogoLink()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            Assert.DoesNotThrow(() => homePage = homePage.AcumenLogoLink());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Home link on the navigation menu  " +
                    "Then I stay on the Home page")]
        public void VerifyNavigationLinksHome()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            Assert.DoesNotThrow(() => homePage = homePage.Home());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the What we do link on the navigation menu  " +
                    "Then I move to the What We Do section")]
        public void VerifyNavigationLinksWhatWeDo()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            Assert.DoesNotThrow(() => homePage = homePage.WhatWeDo());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Client stories link on the navigation menu  " +
                    "Then I shall move to the Client Stories page")]
        public void VerifyNavigationLinksClientStories()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            ClientStoriesPage clientStoriesPage;
            Assert.DoesNotThrow(() => clientStoriesPage = homePage.ClientStories());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Our applications link on the navigation menu  " +
                    "Then I shall move to the Our Applications page")]
        public void VerifyNavigationLinksOurApplications()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            OurApplicationsPage ourApplicationsPage;
            Assert.DoesNotThrow(() => ourApplicationsPage = homePage.OurApplications());
        }
        
        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Join our team link on the navigation menu  " +
                    "Then I shall move to the Join our team page")]
        public void VerifyNavigationLinksJoinOurTeam()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            JoinOurTeamPage joinOurTeamPage;
            Assert.DoesNotThrow(() => joinOurTeamPage = homePage.JoinOurTeam());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Our Apps tile on the tile menu  " +
                    "Then I shall move to the Our applications page")]
        public void VerifyTileLinksOurApps()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            OurApplicationsPage ourApplicationsPage;
            Assert.DoesNotThrow(() => ourApplicationsPage = homePage.OurAppsTile());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Client Stories tile on the tile menu  " +
                    "Then I shall move to the Client stories page")]
        public void VerifyTileLinksClientStories()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            ClientStoriesPage clientStoriesPage;
            Assert.DoesNotThrow(() => clientStoriesPage = homePage.ClientStoriesTile());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the Join Our Team tile on the tile menu  " +
                    "Then I shall move to the Join our team page")]
        public void VerifyTileLinksJoinOurTeam()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            JoinOurTeamPage joinOurTeamPage;
            Assert.DoesNotThrow(() => joinOurTeamPage = homePage.JoinOurTeamTile());
        }

        [Test,
        Description("Given I am on the Acumen home page " +
                    "When I click the What We Do tile on the tile menu  " +
                    "Then I shall move to the What We Do section")]
        public void VerifyTileLinksWhatWeDo()
        {
            //Arrange
            HomePage homePage = new HomePage(_webDriver);

            //Act / Assert
            Assert.DoesNotThrow(() => homePage = homePage.WhatWeDoTile());
        }
    }
}
