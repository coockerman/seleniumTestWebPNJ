using OpenQA.Selenium;
using SeleniumTestPNJstore.Controller;
using SeleniumTestPNJstore.Data;
using SeleniumTestPNJstore.TestPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTestPNJstore.TestScenario
{
    class LoginTest
    {
        private IWebDriver driverSetup;

        [SetUp]
        public void Setup()
        {
            driverSetup = BrowseDrive.GetBrowseDrive();
            
        }
        
        [Test] //Kiểm tra chức năng Đăng nhập khi người dùng nhập thông tin hợp lệ (đã có trong hệ thống)
        public void DN_01()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage loginPage = new LoginPage(driverSetup);
            loginPage.Login(User.UserName, User.Password);

            bool isLoggedIn = loginPage.IsLoggedIn();

            Assert.IsTrue(isLoggedIn, "Login fail");
        }

        [Test]//Kiểm tra khi bỏ trống trường Tài khoản & Mật khẩu
        public void DN_02()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage loginPage = new LoginPage(driverSetup);
            loginPage.Login("", "");

            bool isLoggedFail = loginPage.IsLoggedFail();

            Assert.IsTrue(isLoggedFail, "Fail");
        }

        [Test]//Kiểm tra khi bỏ trống trường Tài khoản
        public void DN_03()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage loginPage = new LoginPage(driverSetup);
            loginPage.Login("", "123456");

            bool isLoggedFail = loginPage.IsLoggedFail();

            Assert.IsTrue(isLoggedFail, "Fail");
        }

        [Test]//Kiểm tra khi bỏ trống trường Mật khẩu
        public void DN_04()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage loginPage = new LoginPage(driverSetup);
            loginPage.Login("nghai123@gmail.com", "");

            bool isLoggedFail = loginPage.IsLoggedFail();

            Assert.IsTrue(isLoggedFail, "Fail");
        }

        [Test]//Kiểm tra khi người dùng nhập sai Tài khoản
        public void DN_05()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage loginPage = new LoginPage(driverSetup);
            loginPage.Login("nghai1230@gmail.com", "123456");

            bool isMessageFail = loginPage.IsMessageFail("Tài khoản hoặc mật khẩu không đúng");

            Assert.IsTrue(isMessageFail, "Fail");
        }

        [Test]//Kiểm tra khi người dùng nhập sai Mật khẩu
        public void DN_06()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage loginPage = new LoginPage(driverSetup);
            loginPage.Login("nghai1@gmail.com", "1234567");

            bool isMessageFail = loginPage.IsMessageFail("Tài khoản hoặc mật khẩu không đúng");

            Assert.IsTrue(isMessageFail, "Fail");
        }
        [TearDown]
        public void CleanUp()
        {
            if (driverSetup != null)
            {
                driverSetup.Quit();  // Đóng trình duyệt
                driverSetup.Dispose(); // Giải phóng tài nguyên
            }
        }
    }
}
