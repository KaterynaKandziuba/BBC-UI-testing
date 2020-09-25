using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.PageObjects
{
    public class CoronavirusPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//li[@class = 'gs-o-list-ui__item--flush gel-long-primer gs-u-display-block gs-u-float-left nw-c-nav__secondary-menuitem-container']//span[text() = 'Your Coronavirus Stories']")]
        private IWebElement yourCoronavirusStoriesTab;

        public CoronavirusPage(IWebDriver driver) : base(driver) { }

        public static CoronavirusPage GetCoronavirusPage
        {
            get
            {
                return new CoronavirusPage(GetDriver.Driver);
            }
        }

        public void ClickYourCoronaVirusStoriesTab() { yourCoronavirusStoriesTab.Click(); }
    }
}
