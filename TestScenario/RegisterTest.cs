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
    class RegisterTest
    {
        private IWebDriver driverSetup;

        [SetUp]
        public void Setup()
        {
            driverSetup = BrowseDrive.GetBrowseDrive();

        }

        [Test] //Bỏ trống tất cả các trường
        public void DK_01()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("", "", "");

            bool isRegister = registerPage.IsRegisterFail();

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Bỏ trống trường "Họ tên", các trường khác nhập đầy đủ
        public void DK_02()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("", "nghai19@gmail.com", "123456");

            bool isRegister = registerPage.IsRegisterFail();

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Bỏ trống trường "Email", các trường khác nhập đầy đủ
        public void DK_03()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("hahahaha", "", "123456aB");

            bool isRegister = registerPage.IsRegisterFail();

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Bỏ trống trường "Mật khẩu", các trường khác nhập đầy đủ
        public void DK_04()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("hahahaha", "nghai19@gmail.com", "");

            bool isRegister = registerPage.IsRegisterFail();

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập Email đã Đăng ký
        public void DK_05()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("hahahaha", "nghai1@gmail.com", "123456aB");

            bool isRegister = registerPage.IsMessageFail("Email đã được sử dụng. Vui lòng thử email khác.");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập Mật khẩu dưới 6 ký tự
        public void DK_06()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("hahahaha", "nghai1@gmail.com", "12");

            bool isRegister = registerPage.IsMessageFail("Mật khẩu không được ngắn hơn 6 ký tự.");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập Mật khẩu trên 20 ký tự
        public void DK_07()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("hahahaha", "nghai1@gmail.com", "1234512345123451234512345");

            bool isRegister = registerPage.IsMessageFail("Mật khẩu không được nhiều hơn 20 ký tự");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập trường "Tên người dùng" dưới 3 ký tự
        public void DK_08()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("ha", "nghai18@gmail.com", "123456aB");

            bool isRegister = registerPage.IsMessageFail("Tên người dùng không được ít hơn 3 ký tự");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập trường "Tên người dùng" trên 50 ký tự
        public void DK_09()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("0123456789012345678901234567890123456789012345678901234", 
                "nghai16@gmail.com", 
                "aB123456");

            bool isRegister = registerPage.IsMessageFail("Tên người dùng không được nhiều hơn 50 ký tự");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập trường "Email" trên 50 ký tự
        public void DK_10()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("Nguyen Van A",
                "a0123456789012345678901234567890123456789012345678901234a@gmail.com",
                "aB123456");

            bool isRegister = registerPage.IsMessageFail("Email không được nhiều hơn 50 ký tự");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập trường "Email" dưới 12 ký tự
        public void DK_11()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("Nguyen Van A", "i@gmail.com", "123456aB");

            bool isRegister = registerPage.IsMessageFail("Email không được ít hơn 12 ký tự");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập Email sai định dạng: chứa ký tự đặc biệt trước @
        public void DK_12()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("Nguyen Van A", "a!@gmail.com", "123456aB");

            bool isRegister = registerPage.IsMessageFail("Email không hợp lệ. Vui lòng nhập đúng định dạng.");

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập Email sai định dạng: chứa ký tự đặc biệt sau @
        public void DK_13()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("Nguyen Van A", "nha5@gmail!.com", "123456aB");

            bool isRegister = registerPage.IsRegisterFail();

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập Email sai định dạng: chứa khoảng trống
        public void DK_14()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("Nguyen Van A", "nh nd@gmail.com", "123456aB");

            bool isRegister = registerPage.IsRegisterFail();

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Nhập đủ và hợp lệ tất cả các trường bắt buộc
        public void DK_15()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register(User.FullNameRegister, User.EmailRegister, User.PasswordRegister);
            Thread.Sleep(10000);

            bool isRegister = registerPage.IsRegisterTrue();

            Assert.IsTrue(isRegister, "Fail");
        }

        [Test] //Kiểm tra chức năng Đăng kí khi người dùng đăng ký liên tục nhiều tài khoản trong thời gian ngắn(60 giây)
        public void DK_16()
        {
            UserHomePage userHomePage = new UserHomePage(driverSetup);
            userHomePage.GoToHomePage();
            userHomePage.NavigateToRegisterPage();

            RegisterPage registerPage = new RegisterPage(driverSetup);
            registerPage.Register("Nguyen Van B", "testAa@gmail.com", "123456aB");

            Thread.Sleep(6000);
            userHomePage.NavigateToRegisterByChangeButton();
            registerPage.Register("Nguyen Van C", "testMa@gmail.com", "123456aB");

            Thread.Sleep(3000);
            bool isRegister = registerPage.IsRegisterFail();

            Assert.IsTrue(isRegister, "Fail");
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
