using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Selenium_Web_Advanced.pageobj;

namespace Selenium_Web_Advanced
{
    public class Tests
    {

        private IWebDriver driver;
        private WebDriverWait wait;
        private LoginPage logPage;
        private HomePage homePage;
        private AllProductsPage allProductsPage;
        private ProductPage productPage;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(1));
        }

        [Test, Order(1)]
        public void Login()
        {
            logPage = new LoginPage(driver);
            homePage = logPage.Login("user", "user");
            string logintext = homePage.TitleText();
            Assert.AreEqual("Home page", logintext);
        }

        [Test, Order(2)]
        public void Add()
        {
            homePage = new HomePage(driver);
            allProductsPage = homePage.ClickOnLink("All Products");
            productPage = allProductsPage.CreateProduct();
            productPage.InputProductName("Spagetti");
            productPage.InputCategoryId("Dairy Products");
            productPage.InputSupplierId("Heli Süßwaren GmbH & Co. KG");
            productPage.InputUnitPrice("17");
            productPage.InputQuantityPerUnit("3");
            productPage.InputUnitsInStock("500");
            productPage.InputUnitsOnOrder("6");
            productPage.InputReorderLevel("9");
            productPage.Submit();
            Assert.AreEqual("All Products", productPage.TitleText());
            Assert.IsTrue(allProductsPage.IsProductPresent("Spagetti"));
        }

        [Test, Order(3)]
        public void CheckProduct()
        {
            productPage = allProductsPage.OpenProduct("Spagetti");
            Assert.AreEqual(productPage.ReadProductName(), "Spagetti");
            Assert.AreEqual(productPage.ReadCategoryId(), "Dairy Products");
            Assert.AreEqual(productPage.ReadSupplierId(), "Heli Süßwaren GmbH & Co. KG");
            Assert.AreEqual(productPage.ReadUnitPrice(), "17,0000");
            Assert.AreEqual(productPage.ReadQuantityPerUnit(), "3");
            Assert.AreEqual(productPage.ReadUnitsInStock(), "500");
            Assert.AreEqual(productPage.ReadUnitsOnOrder(), "6");
            Assert.AreEqual(productPage.ReadReorderLevel(), "9");
            productPage.ToAllProducts();
        }

        [Test, Order(4)]
        public void Delete()
        {
            allProductsPage.RemoveProduct("Spagetti");
            Assert.IsFalse(allProductsPage.IsProductPresent("Spagetti"));
        }

        [Test, Order(5)]
        public void Logout()
        {
            logPage = allProductsPage.Logout();
            Assert.AreEqual("Login", logPage.TitleText());
        }

        [OneTimeTearDown]
        public void QuitDriver()
        {
            driver.Close();
            driver.Quit();
        }

    }
}