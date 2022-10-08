using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace ST01 {
    [TestFixture]
    public class PreencheEmail
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new ChromeDriver();
            baseURL = "https://livros.inoveteste.com.br/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void ThePreencheEmailTest()
        {
            // Acessa contatos novamente
            driver.Navigate().GoToUrl(baseURL + "/contato/");
            driver.FindElement(By.CssSelector("span")).Click();
            Thread.Sleep(10000);
            driver.FindElement(By.CssSelector("#menu-item-80 > a > span")).Click();
            // Clica no campo email
            driver.FindElement(By.Name("your-email")).Click();
            // Preenche com o email
            driver.FindElement(By.Name("your-email")).Clear();
            driver.FindElement(By.Name("your-email")).SendKeys("yagoavebraz@gmail.com");
            // Clica em enviar
            driver.FindElement(By.CssSelector("input.wpcf7-form-control.wpcf7-submit")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
