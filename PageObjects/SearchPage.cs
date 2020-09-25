using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.PageObjects
{
    public class SearchPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//p[@class = 'css-1aofmbn-PromoHeadline ett16tt4']//span[@aria-hidden = 'false']")]
        private IWebElement firstArticleTitle;

        public SearchPage(IWebDriver driver) : base(driver) { }

        public static SearchPage GetSearchPage
        {
            get
            {
                return new SearchPage(GetDriver.Driver);
            }
        }

        public string GetFirstArticleTitleText() { return firstArticleTitle.Text; }
    }
}
