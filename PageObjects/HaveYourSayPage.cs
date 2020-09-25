using Kandziuba_SpecFlow.PageObjects.pages;
using Kandziuba_SpecFlow.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.PageObjects
{
    public class HaveYourSayPage : BasePage
    {
        [FindsBy(How = How.XPath, Using = "//div[@class= 'input-error-message']")]
        private IWebElement ErrorMessage;

        [FindsBy(How = How.XPath, Using = "//button[text() = 'Submit']")]
        private IWebElement submitButton;

        public HaveYourSayPage(IWebDriver driver) : base(driver) { }

        public static HaveYourSayPage GetHaveYourSayPage
        {
            get
            {
                return new HaveYourSayPage(GetDriver.Driver);
            }
        }

        public bool IsErrorMessagePresent()
        {
            try
            {
                return ErrorMessage.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public void ClickSubmitButton() { submitButton.Click(); }
    }
}
