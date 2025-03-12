using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPNJstore.TestPage
{
    class RegisterPage
    {
        private IWebDriver browsDrive;
        private By fullNameInputPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/div[1]/input");
        private By emailInputPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/div[2]/input");
        private By passwordInputPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/div[3]/input");
        private By checkBoxAgreePath = By.XPath("//*[@id=\"app\"]/div/div/div/form/div[4]/input");
        private By buttonRegisterPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/button");

        private By loginFormPath = By.ClassName("login-form");
        private By registerFormPath = By.ClassName("register-form");
        private By textMessagePath = By.XPath("//*[@id=\"app\"]/div/div/div/form/p");
        private By textMessageSuccessPath = By.XPath("//*[@id=\"app\"]/div/div/div/form/p");
        public RegisterPage(IWebDriver driver)
        {
            browsDrive = driver;
        }
        public void EnterFullName(string fullName)
        {
            IWebElement fullNameInput = browsDrive.FindElement(fullNameInputPath);
            fullNameInput.SendKeys(fullName);
            Thread.Sleep(200);
        }
        public void EnterEmail(string email)
        {
            IWebElement emailInput = browsDrive.FindElement(emailInputPath);
            emailInput.SendKeys(email);
            System.Threading.Thread.Sleep(200);
        }
        public void EnterPassword(string password)
        {
            IWebElement passwordInput = browsDrive.FindElement(passwordInputPath);
            passwordInput.SendKeys(password);
            System.Threading.Thread.Sleep(200);
        }
        public void ClickCheckBoxAgree()
        {
            IWebElement checkBoxAgree = browsDrive.FindElement(checkBoxAgreePath);
            checkBoxAgree.Click();
            System.Threading.Thread.Sleep(200);
        }

        public void ClickRegisterButton()
        {
            IWebElement registerButton = browsDrive.FindElement(buttonRegisterPath);
            registerButton.Click();
            System.Threading.Thread.Sleep(2000);
        }

        public bool IsRegisterTrue()
        {
            return browsDrive.FindElement(loginFormPath).Displayed;
        }
        public bool IsRegisterFail()
        {
            return browsDrive.FindElement(registerFormPath).Displayed;
        }
        public bool IsMessageFail(string message)
        {
            IWebElement messageFail = browsDrive.FindElement(textMessagePath);
            if (messageFail.Text.Contains(message))
                return true;
            return false;

        }

        public bool IsSuccessMessage(string message)
        {
            IWebElement messageSuccess = browsDrive.FindElement(textMessagePath);
            if (messageSuccess.Text.Contains(message))
                return true;
            return false;
        }

        public void Register(string fullName, string email, string password)
        {
            EnterFullName(fullName);
            EnterEmail(email);
            EnterPassword(password);
            ClickCheckBoxAgree();
            ClickRegisterButton();
        }
    }
}
