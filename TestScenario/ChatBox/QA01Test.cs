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
public class QA01Test {
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
  public void qA01() {
    driver.Navigate().GoToUrl("http://localhost:5173/user-home");
        Thread.Sleep(3000);
        driver.Manage().Window.Maximize();
        Thread.Sleep(3000);
        driver.FindElement(By.CssSelector(".chat-icon")).Click();
        Thread.Sleep(3000);
        driver.FindElement(By.CssSelector(".chat-icon")).Click();
        Thread.Sleep(3000);
        driver.FindElement(By.CssSelector(".chat-icon")).Click();
        Thread.Sleep(3000);
        driver.Close();
  }
}
