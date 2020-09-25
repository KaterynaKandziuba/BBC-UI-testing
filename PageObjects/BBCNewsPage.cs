using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.PageObjects
{
    public class BBCNewsPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@id = 'sign_in']")]
        private IWebElement signInPopup;

        [FindsBy(How = How.XPath, Using = "//button[@class = 'sign_in-exit']")]
        private IWebElement popupSigninExitButton;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs gs-u-mt0@m gel-1/3@m']//h3[@class = 'gs-c-promo-heading__title gel-paragon-bold nw-o-link-split__text']")]
        private IWebElement headlineArticleTitle;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'gel-layout gel-layout--no-flex nw-c-top-stories--standard nw-c-top-stories--international']" +
                "//h3[@class = 'gs-c-promo-heading__title gel-pica-bold nw-o-link-split__text']")]
        private IList <IWebElement> articleTitles;

        [FindsBy(How = How.XPath, Using = "//div[@class = 'gs-c-promo-body gs-u-display-none gs-u-display-inline-block@m gs-u-mt@xs gs-u-mt0@m gel-1/3@m']//a/span ")]
        private IWebElement categoryLinkText;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder = 'Search']")]
        private IWebElement searchBar;

        [FindsBy(How = How.XPath, Using = "//li[@class = 'gs-o-list-ui__item--flush gel-long-primer gs-u-display-block gs-u-float-left nw-c-nav__wide-menuitem-container']//span[text() = 'Coronavirus']")]
        private IWebElement coronavirusTab;
        public BBCNewsPage(IWebDriver driver) : base(driver) { }

        public static BBCNewsPage GetBBCNewsPage
        {
            get
            {
                return new BBCNewsPage(GetDriver.Driver);
            }
        }

        private bool verifySignInPopupisDisplayed()
        {
            try
            {
                return signInPopup.Displayed;
            }

            catch (Exception)
            {
                return false;
            }
        }

        public void ClickPopupSignInExitButton() { if (verifySignInPopupisDisplayed()) popupSigninExitButton.Click(); }

        public string GetHeadlineArticleTitle() { return headlineArticleTitle.Text; }

        public IList<IWebElement> GetArticleTitlesList() { return articleTitles; }

        public string GetCategoryLinkText() { return categoryLinkText.Text; }

        public void SearchByCategoryLinkText(string keyword) { searchBar.SendKeys(keyword); searchBar.Submit(); }

        public void ClickCoronavirusStoriesTab() { coronavirusTab.Click(); }
    }
}
