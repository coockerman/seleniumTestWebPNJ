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
        private By buttonQuantity = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div[1]/div/div[1]/div[2]/button[2]");
        private By buttonQuantity0 = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div[1]/div/div[1]/div[2]/button[1]");
        private By buttonDelete = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div[1]/div/div[1]/div[2]/button[3]");
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

        public void ClickAddQuantity()
        {
            Thread.Sleep(3000);

            IWebElement addQuantityButton = browsDrive.FindElement(buttonQuantity);
            addQuantityButton.Click();
            Thread.Sleep(3000);
        }
        public void ClickQuantity0()
        {
            Thread.Sleep(5000);

            IWebElement addQuantityButton0 = browsDrive.FindElement(buttonQuantity0);
            addQuantityButton0.Click();
            Thread.Sleep(3000);
        }
        public void DeleteProduct()
        {
            Thread.Sleep(5000);
            IWebElement Delete = browsDrive.FindElement(buttonDelete);
            Thread.Sleep(7000);
            Delete.Click();
            Thread.Sleep(7000);
        }
    }
    }

