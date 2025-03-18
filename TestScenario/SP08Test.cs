// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class SP08Test {
  private IWebDriver driver;
  public IDictionary<string, object> vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
        driver.Dispose();
    }
  [Test]
  public void sP08() {
    driver.Navigate().GoToUrl("http://localhost:5173/user-home");
    driver.Manage().Window.Size = new System.Drawing.Size(1052, 806);
    {
      var element = driver.FindElement(By.CssSelector(".icon-wrapper > a > img"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.CssSelector(".product-list:nth-child(2) .product:nth-child(1) .product-image")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    driver.FindElement(By.CssSelector(".product-card:nth-child(1) .product-image")).Click();
    driver.FindElement(By.CssSelector(".tab-button:nth-child(2)")).Click();
    js.ExecuteScript("window.scrollTo(0,316)");
    driver.FindElement(By.CssSelector("textarea")).Click();
    driver.FindElement(By.CssSelector(".product-detail")).Click();
    driver.FindElement(By.CssSelector(".comment-input-container > button")).Click();
    Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Vui lòng nhập nội dung bình luận!"));
    driver.FindElement(By.CssSelector("textarea")).Click();
    driver.FindElement(By.CssSelector(".comment-input-container > button")).Click();
  }
}
