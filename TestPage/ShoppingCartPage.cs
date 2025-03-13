using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPNJstore.TestPage
{
    class ShoppingCartPage
    {
        private IWebDriver browsDrive;
        private By buttonAddCartPath = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div[1]/div/div/div[2]/button[2]");

        public ShoppingCartPage(IWebDriver driver)
        {
            browsDrive = driver;
        }

        public void ClickAddCartButton()
        {
            Thread.Sleep(3000);

            IWebElement addCartButton = browsDrive.FindElement(buttonAddCartPath);
            addCartButton.Click();
            Thread.Sleep(3000);
        }

    }
}
