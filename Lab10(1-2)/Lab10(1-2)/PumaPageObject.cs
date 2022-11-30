using OpenQA.Selenium;

namespace Lab10_1_2_
{
    public class PumaPageObject
    {
        private IWebDriver _driver;

        public PumaPageObject(IWebDriver driver)
        {
            _driver = driver;
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        private IWebElement _acceptCookiesButton => _driver.FindElement(By.Id("onetrust-accept-btn-handler"));
        private IWebElement _headerSaleButton => _driver.FindElement(By.XPath("//ul[@class=\"p-nav-list\"]//span[contains(text(),\"Sale\")][@class=\"p-nav-item-link-inner\"]"));
        private IWebElement _clothesFirstInListButton => _driver.FindElement(By.XPath("//*[@id=\"product-search-results\"]/div[2]/div[4]/div/div[3]/div[1]/div[1]/div/div/div"));
        private IWebElement _headerMenButton => _driver.FindElement(By.XPath("//*[@id=\"siteHeader\"]/div[1]/div/div[2]/div/div[1]/div[2]/nav/ul/li[2]/a/span"));
        private IWebElement _sneakerItemButton => _driver.FindElement(By.XPath("//*[@id=\"recommendations-content-lsfdkom2d\"]/div/div/div/div/div[1]/div/div[2]/a/div[1]/picture/img"));
        private IWebElement _likeButton => _driver.FindElement(By.XPath("//*[@id=\"page\"]/div[3]/div[3]/div[2]/div[2]/div/div[11]/div/div[3]/div/button"));
        private IWebElement _headerLikeButton => _driver.FindElement(By.XPath("//*[@id=\"siteHeader\"]/div[1]/div/div[2]/div/div[2]/div/div[2]/div/a"));

        public PumaPageObject CheckingTheDisplayOfDiscountsOnTheProductPage()
        {
            _driver.Manage().Timeouts();
            _acceptCookiesButton.Click();
            _driver.Manage().Timeouts();
            _headerSaleButton.Click();
            _driver.Manage().Timeouts();
            _clothesFirstInListButton.Click();
            return new PumaPageObject(_driver);
        }

        public PumaPageObject AddingProductInFavoritesList()
        {
            _driver.Manage().Timeouts();
            _acceptCookiesButton.Click();
            _driver.Manage().Timeouts();
            _headerMenButton.Click();
            _driver.Manage().Timeouts();
            _sneakerItemButton.Click();
            _driver.Manage().Timeouts();
            _likeButton.Click();
            _driver.Manage().Timeouts();
            _headerLikeButton.Click();
            return new PumaPageObject(_driver);
        }

    }
}
