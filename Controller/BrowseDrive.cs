using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPNJstore.Controller
{
    class BrowseDrive
    {
        private static IWebDriver browsDrive;

        public static WebDriver GetBrowseDrive() 
        {
            if (browsDrive == null)
            {
                browsDrive = new ChromeDriver();
            }
            return (WebDriver)browsDrive; 
        }
    }
}
