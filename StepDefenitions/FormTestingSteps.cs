using Kandziuba_SpecFlow.PageObjects;
using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using Kandziuba_SpecFlow.Utilities;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using TechTalk.SpecFlow;

namespace Kandziuba_SpecFlow.StepDefenitions
{
    [Binding]
    public class FormTestingSteps
    {
        [Given(@"I click on the News tab")]
        public void GivenIClickOnTheNewsTab()
        {
            HomePage.GetHomePage.ClickNewsButton();
        }

        [Given(@"I close emerged Sign-in popup")]
        public void GivenICloseEmergedSign_InPopup()
        {
            GetDriver.implicitWait(10);
            BBCNewsPage.GetBBCNewsPage.ClickPopupSignInExitButton();
        }


        [Given(@"I click on the Coronavirus tab")]
        public void GivenIClickOnTheCoronavirusTab()
        {
            BBCNewsPage.GetBBCNewsPage.ClickCoronavirusStoriesTab();
        }
        
        [Given(@"I click on Your Coronavirus Story tab")]
        public void GivenIClickOnYourCoronavirusStoryTab()
        {
            CoronavirusPage.GetCoronavirusPage.ClickYourCoronaVirusStoriesTab();
        }

        [Given(@"I click on Have Your Say tab")]
        public void GivenIClickOnHaveYourSayTab()
        {
            YourCoronavirusStoryPage.GetYourCoronavirusStoryPage.ClickShareWithBBCNewsTab();
        }

        [When(@"I fill the form and checkboxes")]
        public void WhenIFillTheFormAndCheckboxes(Table formTable)
        {
            GetDriver.implicitWait(10);
            Dictionary<string, string> form = TableExtension.ToDictionary(formTable);
            Form.GetForm.FillForm(form);
        }

        [When(@"I press Submit button")]
        public void WhenIPressSubmitButton()
        {
            HaveYourSayPage.GetHaveYourSayPage.ClickSubmitButton();
        }

        [Then(@"error occures")]
        public void ThenErrorOccures()
        {
            Assert.IsTrue(HaveYourSayPage.GetHaveYourSayPage.IsErrorMessagePresent());
        }
    }
}
