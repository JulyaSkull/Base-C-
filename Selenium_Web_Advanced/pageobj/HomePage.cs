using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace Selenium_Web_Advanced.pageobj
{
    class HomePage
    {
        private IWebDriver driver;
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;

        }

        public string TitleText()
        {
            return driver.FindElement(By.XPath("//h2")).Text;
        }

        public AllProductsPage ClickOnLink(string link)
        {
            driver.FindElement(By.XPath($"//div/div/a[text()=\"{link}\"]")).Click();
            return new AllProductsPage(driver);
        }

    }
}
