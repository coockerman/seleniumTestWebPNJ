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
        public UserHomePage(IWebDriver driver)
        {
            browsDrive = driver;
        }

        public void GoToHomePage()
        {
            browsDrive.Navigate().GoToUrl(urlHomePage);
            browsDrive.Manage().Window.Maximize();
        }
        public void HoverToUserIcon()
        {
            IWebElement userIcon = browsDrive.FindElement(userIconPath);
            Actions actions = new Actions(browsDrive);
            actions.MoveToElement(userIcon).Perform();

            Thread.Sleep(200);
        }

        public void ClickNavigateLoginButton()
        {
            IWebElement navigateLoginButton = browsDrive.FindElement(buttonNavigateLoginPath);
            navigateLoginButton.Click();

            Thread.Sleep(300);
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
    }
}
