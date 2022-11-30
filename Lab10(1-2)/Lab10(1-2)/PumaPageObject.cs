using OpenQA.Selenium;

namespace Lab10_1_2_
{
    public class PumaPageObject
    {
        private IWebDriver _driver;

        public PumaPageObject(IWebDriver driver)
        {
            _driver = driver;
            _header = new Header(driver);
            _productList = new ProductListPage(driver);
            _productPage = new ProductPage(driver);
            _saleProduct = new SaleProductPage(driver);
        }

        private IWebElement _acceptCookiesButton => _driver.FindElement(By.Id("onetrust-accept-btn-handler"));

        private SaleProductPage _saleProduct;
        private ProductListPage _productList;
        private ProductPage _productPage;
        private Header _header;

        public PumaPageObject CheckingTheDisplayOfDiscountsOnTheProductPage()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);
            _acceptCookiesButton.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _header.GetSaleButton().Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _saleProduct.GetFirstInList().Click();
            return new PumaPageObject(_driver);
        }

        public PumaPageObject AddingProductInFavoritesList()
        {
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _acceptCookiesButton.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _header.GetMenButton().Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            _productList.GetAdButton().Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _productList.GetSneakerItem().Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _productPage.GetLikeButton().Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _header.GetLikeButton().Click();
            return new PumaPageObject(_driver);
        }

    }
}
