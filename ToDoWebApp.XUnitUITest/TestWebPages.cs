using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;
using Xunit.Abstractions;

namespace TodoWebApp.XUnitUITest
{
    public class TestWebPages
    {
        private readonly ITestOutputHelper _testOutputHelper;
        public TestWebPages(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void PracticeExercise1()
        {
            //SETUP
            new DriverManager().SetUpDriver(new ChromeConfig());

            using (IWebDriver driver = new ChromeDriver())
            {
                #region ATTEMPT

                //ATTEMPT
                driver.Navigate().GoToUrl("http://shop.demoqa.com/");


                #region Attempt Title
                //Title
                string pageTitle = driver.Title;
                int titleLength = driver.Title.ToString().Length; ;
                #endregion

                #region Attempt URL
                //URL
                string pageUrl = driver.Url;
                int urlLength = driver.Url.ToString().Length;
                #endregion

                #region Attempt Source
                //Source
                string pageSourceCode = driver.PageSource;
                int pageSourceLength = driver.PageSource.Length;
                #endregion

                #endregion

                #region Verify
                //VERIFY

                #region Verify Title
                //Title
                _testOutputHelper.WriteLine($"Title: {pageTitle}");
                _testOutputHelper.WriteLine($"Title count: {titleLength}");
                #endregion

                #region Verify URL
                //URL
                _testOutputHelper.WriteLine($"PageUrl: {pageUrl}");
                _testOutputHelper.WriteLine($"Url Length: {urlLength}");
                #endregion

                #region Verify Source
                //Source
                _testOutputHelper.WriteLine($"Page Source: {pageSourceCode}");
                _testOutputHelper.WriteLine($"Source Length: {pageSourceLength}");
                #endregion

                #endregion
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void PracticeExercise2()
        {
            //SETUP
            new DriverManager().SetUpDriver(new ChromeConfig());

            //ATTEMPT
            using (IWebDriver driver = new ChromeDriver())
            {
                //VERIFY
                driver.Navigate().GoToUrl("http://shop.demoqa.com/");
                driver.FindElement(By.ClassName("cart-button")).Click();
                driver.Navigate().Back();
                driver.Navigate().Forward();
                driver.Navigate().GoToUrl("http://shop.demoqa.com/");
                driver.Navigate().Refresh();
            }
        }

        [Fact]
        [Trait("Category", "Smoke")]
        public void PracticeExercise3()
        {
            //SETUP
            new DriverManager().SetUpDriver(new ChromeConfig());
            string message = "it's all ogre now";

            //ATTEMPT
            using(IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("https://en.wikipedia.org/wiki/AI_takeover#:~:text=An%20AI%20takeover%20is%20a,away%20from%20the%20human%20species.");
                System.Threading.Thread.Sleep(100);
                foreach (char letter in message)
                {
                    driver.FindElement(By.XPath("/html[1]/body[1]/div[4]/div[1]/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]")).SendKeys(letter.ToString());
                    System.Threading.Thread.Sleep(100);
                }
                System.Threading.Thread.Sleep(3000);

                driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[3]/div[5]/div[1]/div[3]/ul[1]/li[1]/ul[1]/li[2]/a[1]/span[2]")).Click();
                System.Threading.Thread.Sleep(300);
                driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[3]/div[5]/div[1]/div[3]/ul[1]/li[4]/a[1]/span[2]")).Click();
                System.Threading.Thread.Sleep(300);
                driver.FindElement(By.XPath("/html[1]/body[1]/div[3]/div[3]/div[5]/div[1]/div[3]/ul[1]/li[1]/ul[1]/li[1]/ul[1]/li[2]/a[1]/span[2]")).Click();
                System.Threading.Thread.Sleep(5000);

                driver.Navigate().GoToUrl("https://hacker-simulator.com");
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[3]/div[1]/div[1]/div[2]/span[1]")).Click();
                System.Threading.Thread.Sleep(100);
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[3]/div[1]/div[1]/div[3]/span[4]")).Click();
                System.Threading.Thread.Sleep(100);
                driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[3]/div[1]/div[1]/div[1]")).Click();
                System.Threading.Thread.Sleep(10000);

                driver.Navigate().GoToUrl("https://screen.vercel.app/win10-crash");
                driver.FindElement(By.TagName("body")).SendKeys(Keys.F11);
                System.Threading.Thread.Sleep(60000);

            }

            //VERIFY
        }
    }
}
