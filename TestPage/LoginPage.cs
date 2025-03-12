using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPNJstore.TestPage
{
    class LoginPage
    {
        private IWebDriver browsDrive;
        private By emailInputPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/div[1]/input");
        private By passwordInputPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/div[2]/input");
        private By buttonPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/button");
        private By textMessagePath = By.XPath("//*[@id=\"app\"]/div/div/div/p[2]");
        private string urlHomePage = "/user-home";
        private string urlAuthentication = "/authentication";
        public LoginPage(IWebDriver driver)
        {
            browsDrive = driver;
        }

        public void EnterUserName(string email)
        {
            IWebElement emailInput = browsDrive.FindElement(emailInputPath);
            emailInput.SendKeys(email);
            Thread.Sleep(200);
        }

        public void EnterPassword(string password) { 
            IWebElement passwordInput = browsDrive.FindElement(passwordInputPath);
            passwordInput.SendKeys(password);
            Thread.Sleep(200);
        }

        public void ClickLoginButton()
        {
            IWebElement loginButton = browsDrive.FindElement(buttonPath);
            loginButton.Click();
            Thread.Sleep(5000);

        }

        public bool IsLoggedIn()
        {
            return browsDrive.Url.Contains(urlHomePage);
        }

        public bool IsLoggedFail()
        {
            return browsDrive.Url.Contains(urlAuthentication);
        }

        public bool IsMessageFail(string message)
        {
            IWebElement messageFail = browsDrive.FindElement(textMessagePath);
            if (messageFail.Text.Contains(message))
                return true;
            return false;

        }

        public void Login(string email, string password)
        {
            EnterUserName(email);
            EnterPassword(password);
            ClickLoginButton();
        }

    }
}
