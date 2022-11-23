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

        [Test]
        public void CheckingTheDisplayOfDiscountsOnTheProductPage()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//ul[@class=\"p-nav-list\"]//span[contains(text(),\"Sale\")][@class=\"p-nav-item-link-inner\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id=\"product-search-results\"]/div[2]/div[4]/div/div[3]/div[1]/div[1]/div/div/div")).Click();
            driver.Close();
        }

        [Test]
        public void AddingProductInFavoritesList()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//*[@id=\"siteHeader\"]/div[1]/div/div[2]/div/div[1]/div[2]/nav/ul/li[2]/a/span")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//*[@id=\"recommendations-content-lsfdkom2d\"]/div/div/div/div/div[1]/div/div[2]/a/div[1]/picture/img")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id=\"page\"]/div[3]/div[3]/div[2]/div[2]/div/div[11]/div/div[3]/div/button")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//*[@id=\"siteHeader\"]/div[1]/div/div[2]/div/div[2]/div/div[2]/div/a")).Click();
            if (driver.FindElement(By.XPath("//*[@id=\"page\"]/div[4]/div[1]/div/div/div/div[1]/div[2]/div[1]/div[2]/div[1]/div[2]/div[1]/div/div[1]/div/div/div[2]")).GetAttribute("value") != "1") ;

            driver.Close();
        }
    }
}