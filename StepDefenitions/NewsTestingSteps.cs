using Kandziuba_SpecFlow.PageObjects;
using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using Kandziuba_SpecFlow.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Kandziuba_SpecFlow.StepDefenitions
{
    [Binding]
    public class NewsTestingSteps
    {

        [Given(@"the website is opened on the main page")]
        public void GivenTheWebsiteIsOpenedOnTheMainPage()
        {
            BasePage.GetBasePage.NavigateToBBC();
        }

        [When(@"I click on the News tab")]
        public void WhenIClickOnTheNewsTab()
        {
            HomePage.GetHomePage.ClickNewsButton();
        }

        [When(@"I close emerged Sign-in popup")]
        public void WhenICloseEmergedSign_InPopup()
        {
            GetDriver.implicitWait(10);
            BBCNewsPage.GetBBCNewsPage.ClickPopupSignInExitButton();
        }

        [Then(@"I check headline article against ""(.*)""")]
        public void ThenICheckHeadlineArticleAgainst(string expectedTitle)
        {
            Assert.AreEqual(expectedTitle, BBCNewsPage.GetBBCNewsPage.GetHeadlineArticleTitle());
        }

        [Then(@"I check secondary article titles against Titles")]
        public void ThenICheckSecondaryArticleTitlesAgainstTitles(Table expectedSecondaryTitles)
        {
            IList<IWebElement> articletitles = BBCNewsPage.GetBBCNewsPage.GetArticleTitlesList();
            int i = 0;
            foreach (IWebElement title in articletitles)
            {
                Assert.AreEqual(TableExtension.ToList(expectedSecondaryTitles)[i], title.Text);
                i++;
            }
        }

        [When(@"I store the text of the Category link of the headline article to enterin the Search bar")]
        public void WhenIEnterThisTextInTheSearchBar()
        {
            BBCNewsPage.GetBBCNewsPage.SearchByCategoryLinkText(BBCNewsPage.GetBBCNewsPage.GetCategoryLinkText());
        }


        [Then(@"I check the name of the first article in the list against ""(.*)""")]
        public void ThenICheckTheNameOfTheFirstArticleInTheListAgainst(string expectedFirstSearchArticle)
        {
            Assert.AreEqual(expectedFirstSearchArticle, SearchPage.GetSearchPage.GetFirstArticleTitleText());
        }
    }
}
