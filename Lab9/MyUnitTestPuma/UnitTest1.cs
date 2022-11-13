using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace MyUnitTestPuma
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://eu.puma.com/";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.Id("onetrust-accept-btn-handler")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(By.XPath("//ul[@class=\"p-nav-list\"]//span[contains(text(),\"Sale\")][@class=\"p-nav-item-link-inner\"]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            driver.FindElement(By.XPath("//*[@id=\"product-search-results\"]/div[2]/div[4]/div/div[3]/div[1]/div[1]/div/div/div")).Click();
            driver.Close();
        }
    }
}