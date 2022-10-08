using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using SeleniumExtras.PageObjects;
namespace ST01 {
    internal class Contato 
        {
        [FindsBy(How =How.Name, Using = "your - email")]
    public IWebElement name { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.wpcf7-form-control.wpcf7-submit")]
        public IWebElement click { get; set; }


    }
}
