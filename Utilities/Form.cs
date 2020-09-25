using Kandziuba_SpecFlow.PageObjects.pages;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.Utilities
{
    class Form
    {
        private IWebDriver driver;

        [FindsBy(How = How.XPath, Using = "//input[@type = 'checkbox'] ")]
        private IList <IWebElement> checkboxes;

        public Form(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public static Form GetForm
        {
            get
            {
                return new Form(GetDriver.Driver);
            }
        }

        public void FillForm(Dictionary<string, string> values) //make function reusable
        {
            foreach (var value in values)
            {
                if (value.Value != null)
                    driver.FindElement(By.XPath("//*[contains(@aria-label, " + value.Key + ")]")).SendKeys(value.Value);
                foreach (var checkbox in checkboxes)
                if (value.Value == "press") checkbox.Click();
            }
        }
    }
}
