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
public class SP06Test {
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
  public void sP06() {
    driver.Navigate().GoToUrl("http://localhost:5173/user-home");
    driver.Manage().Window.Size = new System.Drawing.Size(1536, 824);
    driver.FindElement(By.CssSelector(".product-list:nth-child(2) .product:nth-child(1) .product-image")).Click();
    driver.FindElement(By.CssSelector(".product-card:nth-child(1) .product-image")).Click();
    driver.FindElement(By.CssSelector(".cart-btn")).Click();
    Assert.That(driver.SwitchTo().Alert().Text, Is.EqualTo("Thêm sản phẩm vào giỏ hàng thành công!"));
  }
}
