using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPNJstore.TestPage
{
    class ProfilePage
    {
        private IWebDriver browsDrive;
        private string urlFrofilePage = "/userProfile";
        private By inputEmailPath = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div[2]/div/div[2]/div/input");
        private By inputSdtPath = By.XPath("//*[@id=\"app\"]/div/div/div[1]/div/div/div[2]/div/div[3]/input");
        public ProfilePage(IWebDriver driver)
        {
            browsDrive = driver;
        }


        public bool IsCheckEmail(string email)
        {
            Thread.Sleep(2000);
            IWebElement emailInput = browsDrive.FindElement(inputEmailPath);
            string emailValue = emailInput.GetAttribute("value");
            return emailValue == email;
        }

        public bool IsCheckSdt(string sdt)
        {
            Thread.Sleep(2000);
            IWebElement sdtInput = browsDrive.FindElement(inputSdtPath);
            string sdtValue = sdtInput.GetAttribute("value");
            return sdtValue == sdt;
        }

        public bool IsProfilePage()
        {
            Thread.Sleep(2000);
            return browsDrive.Url.Contains(urlFrofilePage);
        }

    }
}
