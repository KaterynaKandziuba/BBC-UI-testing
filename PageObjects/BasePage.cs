using Kandziuba_SpecFlow.PageObjects.pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kandziuba_SpecFlow.pages
{
    public class BasePage
    {
        private IWebDriver driver;

        private static string BBC_URL = "https://www.bbc.com";


        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public static BasePage GetBasePage
        {
            get
            {
                return new BasePage(GetDriver.Driver);
            }
        }

        public void NavigateToBBC() 
        {
            driver.Navigate().GoToUrl(BBC_URL);
        }

    }
}
