using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestPNJstore
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("http://localhost:5173/");
            driver.Manage().Window.Maximize();

            Thread.Sleep(2000); // Chờ trang load (nếu cần)

            // Tìm phần tử đầu tiên để hover
            IWebElement webElement = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/nav/div[3]/div[2]/img"));

            // Tạo đối tượng Actions để thực hiện hover
            Actions actions = new Actions(driver);
            actions.MoveToElement(webElement).Perform(); // Hover vào phần tử

            Thread.Sleep(1000); // Chờ UI phản hồi (nếu cần)

            // Tìm và click vào phần tử thứ hai
            IWebElement webElement2 = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/nav/div[3]/div[2]/div/button"));
            webElement2.Click();
            Thread.Sleep(3000); // Chờ trang chuyển hướng (nếu có)

            // Tìm ô input Email và nhập
            IWebElement emailInput = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div/form/div[1]/input"));
            emailInput.SendKeys("nghai1@gmail.com");
            Thread.Sleep(500); // Chờ trang chuyển hướng (nếu có)

            // Tìm ô input Password và nhập
            IWebElement passwordInput = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div/form/div[2]/input"));
            passwordInput.SendKeys("123456");

            // Tìm và click vào nút đăng nhập
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"app\"]/div/div/div/form/button"));
            loginButton.Click();

            // Chờ phản hồi (nếu cần)
            Thread.Sleep(3000);

            // Đóng trình duyệt
            driver.Quit();
        }
    }
}