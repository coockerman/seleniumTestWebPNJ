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
    class ProfileTest
    {
        private IWebDriver driverSetup;

        [SetUp]
        public void Setup()
        {
            driverSetup = BrowseDrive.GetBrowseDrive();

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
        [Test] //Hien thi thong tin user
        public void PF_01()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserNameHai, User.PasswordHai);
            userHomePage.NavigateToProfilePage();


            ProfilePage profilePage = new ProfilePage(driverSetup);
            bool isProfilePage =  profilePage.IsProfilePage();

            Assert.IsTrue(isProfilePage, "Fail");
        }
        [Test] //Hien thi thong tin user
        public void PF_02()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserNameHai, User.PasswordHai);
            userHomePage.NavigateToProfilePage();


            ProfilePage profilePage = new ProfilePage(driverSetup);
            bool isProfilePage = profilePage.IsProfilePage();

            Assert.IsTrue(isProfilePage, "Fail");
        }
        

        [Test] //Hien thi thong tin email va sdt
        public void PF_03()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserNameHai, User.PasswordHai);
            userHomePage.NavigateToProfilePage();


            ProfilePage profilePage = new ProfilePage(driverSetup);
            bool isCheckEmail = profilePage.IsCheckEmail(User.UserNameHai);
            bool isCheckSdt = profilePage.IsCheckSdt("0213424234");

            Assert.IsTrue(isCheckEmail&&isCheckSdt, "Fail");
        }
        [Test] //Hien thi thong tin user
        public void PF_04()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserNameHai, User.PasswordHai);
            userHomePage.NavigateToProfilePage();


            ProfilePage profilePage = new ProfilePage(driverSetup);
            bool isProfilePage = profilePage.IsProfilePage();

            Assert.IsTrue(isProfilePage, "Fail");
        }
        [Test] //Hien thi thong tin user
        public void PF_05()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserNameHai, User.PasswordHai);
            userHomePage.NavigateToProfilePage();


            ProfilePage profilePage = new ProfilePage(driverSetup);
            bool isProfilePage = profilePage.IsProfilePage();

            Assert.IsTrue(isProfilePage, "Fail");
        }
        [Test] 
        public void PF_06()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserNameHai, User.PasswordHai);
            userHomePage.NavigateToProfilePage();


            ProfilePage profilePage = new ProfilePage(driverSetup);
            bool isProfilePage = profilePage.IsProfilePage();

            Assert.IsTrue(isProfilePage, "Fail");
        }
    }
}
