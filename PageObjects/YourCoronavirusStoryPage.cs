using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.PageObjects
{
    public class YourCoronavirusStoryPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "(//a[@class = 'gs-c-promo-heading gs-o-faux-block-link__overlay-link gel-pica-bold nw-o-link-split__anchor'])[19]")]
        private IWebElement shareWithBBCNewsTab;
        public YourCoronavirusStoryPage(IWebDriver driver) : base(driver) { }
        public static YourCoronavirusStoryPage GetYourCoronavirusStoryPage
        {
            get
            {
                return new YourCoronavirusStoryPage(GetDriver.Driver);
            }
        }
        public void ClickShareWithBBCNewsTab() { shareWithBBCNewsTab.Click(); }
    }
}
