using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TP3MPC.Controllers;
using Xunit;

namespace TP3MPC.Testes
{
    public class TestesSelenium
    {
      
        [Fact]
        public void TP3Teste()
        {
            IWebDriver driver = new ChromeDriver();
            


            driver.Url = "https://www.google.com/";
            driver.Navigate();
            var nome = driver.FindElement(By.ClassName("gb_d"));

            Assert.True(nome.Text == "Gmail");
            driver.Quit();
        }
    }
}
