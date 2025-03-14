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
public class DM006Test {
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
  public void dM006() {
    driver.Navigate().GoToUrl("http://localhost:5173/user-home");
    driver.Manage().Window.Size = new System.Drawing.Size(788, 816);
    {
      var element = driver.FindElement(By.LinkText("TRANG SỨC"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element, 0, 0).Perform();
    }
    driver.FindElement(By.CssSelector(".product-list:nth-child(2) .product:nth-child(4) .product-image")).Click();
    js.ExecuteScript("window.scrollTo(0,0)");
    {
      var element = driver.FindElement(By.CssSelector(".filter-section:nth-child(3) .filter-btn:nth-child(3)"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    driver.FindElement(By.CssSelector(".filter-section:nth-child(4) .filter-btn:nth-child(1)")).Click();
    {
      var element = driver.FindElement(By.CssSelector(".price-slider"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).ClickAndHold().Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".price-slider"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.CssSelector(".price-slider"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Release().Perform();
    }
    driver.FindElement(By.CssSelector(".price-slider")).SendKeys("23000000");
    driver.FindElement(By.CssSelector(".price-slider")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".filter-section:nth-child(4) .filter-btn:nth-child(2)")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".filter-section:nth-child(4) .filter-btn:nth-child(3)")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
    driver.FindElement(By.CssSelector(".filter-section:nth-child(4) .filter-btn:nth-child(4)")).Click();
    driver.FindElement(By.CssSelector(".search-btn")).Click();
  }
}
