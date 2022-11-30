using Lab10_1_2_;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace Lab10
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "https://eu.puma.com/";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void CheckingTheDisplayOfDiscountsOnTheProductPage()
        {
            var pumaPage = new PumaPageObject(driver);
            pumaPage.CheckingTheDisplayOfDiscountsOnTheProductPage();
            TearDown();
        }

        [Test]
        public void AddingProductInFavoritesList()
        {
            var pumaPage = new PumaPageObject(driver);
            pumaPage.AddingProductInFavoritesList();
            TearDown();
        }
    }
}