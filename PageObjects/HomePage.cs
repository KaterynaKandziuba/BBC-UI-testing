using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.PageObjects
{
    public class HomePage : BasePage
    {

        [FindsBy(How = How.XPath, Using = "//div[@id = 'orb-nav-links']//a[text() = 'News']")]
        private IWebElement newsButton;

        public HomePage(IWebDriver driver) : base(driver) {}

        public static HomePage GetHomePage
        {
            get
            {
                return new HomePage(GetDriver.Driver);
            }
        }

        public void ClickNewsButton() { newsButton.Click(); }
    }
}
