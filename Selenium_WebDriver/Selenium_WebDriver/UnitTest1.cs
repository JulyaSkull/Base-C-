using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace SeleniumWebDriver
{
    public class Tests
    {

        private IWebDriver driver;

        public bool isElementPresent(By locator)
        {
            try
            {
                driver.FindElement(locator);
            }
            catch (NoSuchElementException)
            {
                return false;
            }
            return true;
        }

        [OneTimeSetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
        }

        [Test, Order(1)]
        public void Test1_Login()
        {

            driver.FindElement(By.Id("Name")).SendKeys("user");
            driver.FindElement(By.Id("Password")).SendKeys("user");
            driver.FindElement(By.CssSelector(".btn")).Click();
            string AfterLoginText = driver.FindElement(By.XPath("//h2")).Text;
            Assert.AreEqual("Home page", AfterLoginText);
        }

        [Test, Order(2)]
        public void Test2_Add()
        {
            driver.FindElement(By.XPath("//div/div/a[text()=\"All Products\"]")).Click();
            driver.FindElement(By.XPath("//div/a[text()=\"Create new\"]")).Click();
            driver.FindElement(By.Id("ProductName")).SendKeys("Spaghetti");
            IWebElement selectElemCat = driver.FindElement(By.Id("CategoryId"));
            SelectElement selectCategory = new SelectElement(selectElemCat);
            selectCategory.SelectByValue("4");
            IWebElement selectSupplier = driver.FindElement(By.Id("SupplierId"));
            SelectElement selectSup = new SelectElement(selectSupplier);
            selectSup.SelectByValue("11");
            driver.FindElement(By.Id("UnitPrice")).SendKeys("17");
            driver.FindElement(By.Id("QuantityPerUnit")).SendKeys("3");
            driver.FindElement(By.Id("UnitsInStock")).SendKeys("500");
            driver.FindElement(By.Id("UnitsOnOrder")).SendKeys("6");
            driver.FindElement(By.Id("ReorderLevel")).SendKeys("9");
            driver.FindElement(By.CssSelector(".btn")).Click();
            string ProductsText = driver.FindElement(By.XPath("//h2")).Text;
            Assert.AreEqual("All Products", ProductsText);
            Assert.IsTrue(isElementPresent(By.XPath("//*[@class='table']//a[text()='Spaghetti']")));
        }

        [Test, Order(3)]
        public void Test3_CheckProduct()
        {
            driver.FindElement(By.XPath("//a[contains(text(),'Spaghetti')]")).Click();
            string ProductName = driver.FindElement(By.XPath("//input[@name=\"ProductName\"]")).GetAttribute("value");
            string UnitPrice = driver.FindElement(By.XPath("//input[@id=\"UnitPrice\"]")).GetAttribute("value");
            string QuantityPerUnit = driver.FindElement(By.XPath("//input[@id=\"QuantityPerUnit\"]")).GetAttribute("value");
            string UnitsInStock = driver.FindElement(By.XPath("//input[@id=\"UnitsInStock\"]")).GetAttribute("value");
            string UnitsOnOrder = driver.FindElement(By.XPath("//input[@id=\"UnitsOnOrder\"]")).GetAttribute("value");
            string ReorderLevel = driver.FindElement(By.XPath("//input[@id=\"ReorderLevel\"]")).GetAttribute("value");
            IWebElement selectElemCat = driver.FindElement(By.Id("CategoryId"));
            SelectElement selectCat = new SelectElement(selectElemCat);
            string CategoryId = selectCat.SelectedOption.Text;
            IWebElement selectElemSup = driver.FindElement(By.Id("SupplierId"));
            SelectElement selectElemCup = new SelectElement(selectElemSup);
            string SupplierId = selectElemCup.SelectedOption.Text;
            Assert.AreEqual(ProductName, "Spaghetti");
            Assert.AreEqual(CategoryId, "Dairy Products");
            Assert.AreEqual(SupplierId, "Heli Süßwaren GmbH & Co. KG");
            Assert.AreEqual(UnitPrice, "17,0000");
            Assert.AreEqual(QuantityPerUnit, "3");
            Assert.AreEqual(UnitsInStock, "500");
            Assert.AreEqual(UnitsOnOrder, "6");
            Assert.AreEqual(ReorderLevel, "9");
            driver.FindElement(By.XPath("//a[text()=\"All Products\"]")).Click();
        }

        [Test, Order(4)]
        public void Test_Logout()
        {
            driver.FindElement(By.XPath("//a[text()=\"Logout\"]")).Click();
            Assert.AreEqual(driver.FindElement(By.XPath("//h2")).Text, "Login");
        }


        [OneTimeTearDown]
        public void QuitDriver()
        {
            driver.Close();
            driver.Quit();
        }

    }
}