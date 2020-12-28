using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using Selenium_Web_Framework.pageobj;
using Selenium_Web_Framework.business_objects;
using Selenium_Web_Framework.service;

namespace Selenium_Web_Framework
{
    public class Tests
    {

        private IWebDriver driver;
        private LoginPage loginPage;
        private HomePage homePage;
        private AllProductsPage allProductsPage;
        private ProductPage productPage;
        private Product spagetti = new Product("Spagetti", "Dairy Products", "Heli Süßwaren GmbH & Co. KG", "17", "3", "500", "6", "9");
        private ProductServices productServices;


        [OneTimeSetUp]
        public void Setup()
        {

            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000");
            driver.Manage().Window.Maximize();           
        }

        [Test, Order(1)]
        public void Login()
        {

            loginPage = new LoginPage(driver);
            homePage = loginPage.Login("user", "user");
            Assert.AreEqual("Home page", homePage.TitleText());
        }

        [Test, Order(2)]
        public void Add()
        {
            productServices = new ProductServices();
            productPage = new ProductPage(driver);
            productServices.InputProduct(spagetti, driver);
            allProductsPage = new AllProductsPage(driver);
            Assert.AreEqual("All Products", productPage.TitleText());
            Assert.IsTrue(allProductsPage.IsProductPresent(spagetti.productName));
        }

        [Test, Order(3)]
        public void CheckProduct()
        {
            Product readProduct = productServices.ReadProduct(spagetti, driver);
            Assert.AreEqual(spagetti, readProduct);
            productPage.ToAllProducts();
        }

        [Test, Order(4)]
        public void Delete()
        {
            productServices.DeleteProduct(spagetti, driver);
            Assert.IsFalse(allProductsPage.IsProductPresent(spagetti.productName));
        }

        [Test, Order(5)]
        public void Logout()
        {
            loginPage = allProductsPage.Logout();
            Assert.AreEqual("Login", loginPage.TitleText());
        }

        [OneTimeTearDown]
        public void QuitDriver()
        {
            driver.Close();
            driver.Quit();
        }

    }
}