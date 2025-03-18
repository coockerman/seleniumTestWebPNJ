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
    class ShoppingCartTest
    {
        private IWebDriver driverSetup;

        [SetUp]
        public void Setup()
        {
            driverSetup = BrowseDrive.GetBrowseDrive();

        }


        [Test] //Kiem tra chuc nang them san pham vao gio
        public void GH_04()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserName, User.Password);

            UserHomePage Add = new UserHomePage(driverSetup);
            Add.NavigateToCategory();
            Add.NavigateToProduct();

        }
        [Test] //Kiem tra chuc nang them so luong
        public void GH_01()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserName, User.Password);

            userHomePage.NavigateToShoppingCartPage();

            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(driverSetup);
            shoppingCartPage.ClickAddQuantity();
        }
        [Test] //Kiem tra chuc nang giam so luong san pham
        public void GH_02()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserName, User.Password);

            userHomePage.NavigateToShoppingCartPage();

            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(driverSetup);
            shoppingCartPage.ClickQuantity0();
        }
        [Test] //Kiem tra chuc nang xoa sản phẩm
        public void GH_03()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToLoginPage();

            LoginPage login = new LoginPage(driverSetup);
            login.Login(User.UserName, User.Password);

            userHomePage.NavigateToShoppingCartPage();

            ShoppingCartPage shoppingCartPage = new ShoppingCartPage(driverSetup);
            shoppingCartPage.DeleteProduct();
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
