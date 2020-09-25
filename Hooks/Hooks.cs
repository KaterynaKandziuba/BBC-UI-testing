using Kandziuba_SpecFlow.PageObjects;
using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace Kandziuba_SpecFlow.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            driver = GetDriver.Driver;
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
            driver = null;
        }

    }
}
