using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumTestPNJstore.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPNJstore.TestPage
{
    class UserHomePage
    {
        private IWebDriver browsDrive;
        private string urlHomePage = "http://localhost:5173/user-home";
        private By userIconPath = By.XPath("//*[@id=\"app\"]/div/div/nav/div[3]/div[2]/img");
        private By buttonNavigateLoginPath = By.XPath("//*[@id=\"app\"]/div/div/nav/div[3]/div[2]/div/button");
        private By buttonNavigateRegisterPath = By.XPath("//*[@id=\"app\"]/div/div/div/p[2]/a");
        private By buttonNavigateShoppingCartPath = By.XPath("//*[@id=\"app\"]/div/div/nav/div[3]/div[1]/a");
        private By buttonNavigateCategoryProduct = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div[2]/div/div[3]/a");
        private By buttonNavigateProduct = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div[2]/div/div[2]/div[1]");
        private By buttonNavigateAddProduct = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div[1]/div[3]/div[4]/div");
        

        public UserHomePage(IWebDriver driver)
        {
            browsDrive = driver;
        }

        public void GoToHomePage()
        {
            browsDrive.Navigate().GoToUrl(urlHomePage);
            browsDrive.Manage().Window.Maximize();
        }
        void HoverToUserIcon()
        {
            IWebElement userIcon = browsDrive.FindElement(userIconPath);
            Actions actions = new Actions(browsDrive);
            actions.MoveToElement(userIcon).Perform();

            Thread.Sleep(200);
        }

        void ClickNavigateLoginButton()
        {
            IWebElement navigateLoginButton = browsDrive.FindElement(buttonNavigateLoginPath);
            navigateLoginButton.Click();

            Thread.Sleep(300);
        }
        void ClickNavigateShoppingCartButton()
        {
            IWebElement navigateShoppingCartButton = browsDrive.FindElement(buttonNavigateShoppingCartPath);
            navigateShoppingCartButton.Click();
        }


        public void NavigateToShoppingCartPage()
        {
            Thread.Sleep(1000); //Delay mot chut de trang web load

            ClickNavigateShoppingCartButton();
        }
        public void NavigateToLoginPage()
        {
            Thread.Sleep(500);
            HoverToUserIcon();
            ClickNavigateLoginButton();
        }
        public void NavigateToRegisterByChangeButton()
        {
            Thread.Sleep(500);
            IWebElement navigateRegisterButton = browsDrive.FindElement(buttonNavigateRegisterPath);
            navigateRegisterButton.Click();
        }
        public void NavigateToRegisterPage()
        {
            NavigateToLoginPage();
            NavigateToRegisterByChangeButton();
        }
        void ClickCategory()
        {
            IWebElement navigateCategory= browsDrive.FindElement(buttonNavigateCategoryProduct);
            navigateCategory.Click();
        }


        public void NavigateToCategory()
        {
            Thread.Sleep(1000); //Delay mot chut de trang web load

            ClickCategory();
        }

        public void NavigateToProduct()
        {
            Thread.Sleep(1000); //Delay mot chut de trang web load

            ClickCategory();
            IWebElement navigateProduct = browsDrive.FindElement(buttonNavigateProduct);
            navigateProduct.Click();
            Thread.Sleep(6000);
            IWebElement navigateAddProduct = browsDrive.FindElement(buttonNavigateAddProduct);
            navigateAddProduct.Click();
            Thread.Sleep(9000);

        }

    }
}
