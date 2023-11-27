using Microsoft.Extensions.Options;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOnlineShop
{
    internal class IntegrationTests
    {
        IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            string path = "G:\\VS projects\\TestOnlineShop\\TestOnlineShop\\drivers\\"; //Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

            FirefoxOptions options = new FirefoxOptions();
            options.BinaryLocation = "C:\\Program Files\\Mozilla Firefox\\firefox.exe";

            driver = new FirefoxDriver(path, options);
        }

        [Test]

        public void VerifyLogo()

        {

            driver.Navigate().GoToUrl("https://localhost:44364");

            IWebElement element = driver.FindElement(By.ClassName("navbar-brand"));

            Assert.IsTrue(element.Displayed);

        }

        [Test]
        public void VerifyHeader()
        {
            driver.Navigate().GoToUrl("https://localhost:44364");

            IWebElement header = driver.FindElement(By.ClassName("display-2"));

            Assert.IsTrue(header.Displayed);
            
        }

        [Test]
        public void VerifyDescription()
        {
            driver.Navigate().GoToUrl("https://localhost:44364");
            IWebElement description = driver.FindElement(By.XPath("//*[@class='container align-content-center']"));
            Assert.IsTrue(description.Displayed);
        }

        [Test]
        public void TestAutentification()
        {
            driver.Navigate().GoToUrl("https://localhost:44364/users/login");

            IWebElement login = driver.FindElement(By.Id("Login"));
            login.SendKeys("username1");
            IWebElement password = driver.FindElement(By.Id("Password"));
            password.SendKeys("Root#0000");

            IWebElement button = driver.FindElement(By.Id("id-btn-login"));

            button.Click();

            Thread.Sleep(100);

            var loginInfo = driver.FindElement(By.Id("id-logininfo"));

            bool flag = loginInfo.Displayed;

            Assert.True(flag);
        }

        [OneTimeTearDown]
        public void Finalize()
        {
            driver.Close();
        }
    }
}
