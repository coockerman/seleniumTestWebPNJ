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
public class DM007Test {
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
  public void dM007() {
    driver.Navigate().GoToUrl("http://localhost:5173/user-home");
    driver.Manage().Window.Size = new System.Drawing.Size(1552, 832);
    driver.FindElement(By.CssSelector(".product-list:nth-child(2) .product:nth-child(1) .product-image")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    driver.FindElement(By.CssSelector(".filter-section:nth-child(5) .filter-btn:nth-child(1)")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".filter-section:nth-child(5) .filter-btn:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".filter-section:nth-child(5) .filter-btn:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".pageMain")).Click();
    driver.FindElement(By.CssSelector(".filter-options > .active")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".filter-section:nth-child(5) .filter-btn:nth-child(4)")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".filter-section:nth-child(5) .filter-btn:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".filter-sidebar")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
  }
}
