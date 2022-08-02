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
                _testOutputHelper.WriteLine($"Title: {pageUrl}");
                _testOutputHelper.WriteLine($"Title count: {urlLength}");
                #endregion

                #region Verify Source
                //Source
                _testOutputHelper.WriteLine($"Title: {pageSourceCode}");
                _testOutputHelper.WriteLine($"Title count: {pageSourceLength}");
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

            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Navigate().GoToUrl("http://shop.demoqa.com/");
                driver.FindElement(By.ClassName("cart-button")).Click();
                driver.Navigate().Back();
            }

            //ATTEMPT

            //VERIFY
        }
    }
}
