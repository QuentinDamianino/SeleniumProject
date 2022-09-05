// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumCSharp.BaseClass;

namespace SeleniumCSharp
{
    [TestFixture]
    public class TestClass : BaseTest
    {
        [Test, Category("Smoke testing")]
        public void TestMethod1()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");

            IWebElement cookiesButton = driver.FindElement(By.XPath("//button[text()='Zezwól na korzystanie z niezbędnych i opcjonalnych plików cookie']"));
            cookiesButton.Click();

            IWebElement registerButton = driver.FindElement(By.XPath("//a[text()='Utwórz nowe konto']"));
            registerButton.Click();

            Thread.Sleep(1000);

            IWebElement monthDropdownList = driver.FindElement(By.XPath(".//*[@id='month']"));
            SelectElement element = new SelectElement(monthDropdownList);
            element.SelectByIndex(1);
            element.SelectByText("mar");
            element.SelectByValue("6");
        }

        [Test, Category("Regression testing")]
        public void TestMethod2()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#");
        }

        [Test, Category("Smoke testing")]
        public void TestMethod3()
        {
            IWebElement emailTextField = driver.FindElement(By.XPath(".//*[@id='email']"));
            emailTextField.SendKeys("Selenium C#Selenium C#Selenium C#Selenium C#");
            Thread.Sleep(5000);
        }
    }
}
