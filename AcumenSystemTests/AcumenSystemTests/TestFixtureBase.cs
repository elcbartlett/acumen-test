using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace AcumenSystemTests
{
    public abstract class TestFixtureBase
    {
        protected IWebDriver _webDriver;

        [SetUp]
        public void SetUp()
        {
            _webDriver = new FirefoxDriver();
            _webDriver.Navigate().GoToUrl("http://www.acumenci.com/");
        }

        [TearDown]
        public void TearDown()
        {
            _webDriver.Dispose();
            _webDriver = null;
        }

    }
}
