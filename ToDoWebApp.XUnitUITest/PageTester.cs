using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager;
using WebDriverManager.DriverConfigs.Impl;
using Xunit;

namespace TodoWebApp.XUnitUITest
{
    public class PageTester
    {
        [Fact]
        [Trait("Category", "Smoke")]
        public void StartLoadApplicationPage()
        {
            //SETUP
            new DriverManager().SetUpDriver(new ChromeConfig());

            using (IWebDriver driver = new ChromeDriver())
            {
                //ATTEMPT
                driver.Navigate().GoToUrl("https://localhost:44346/");

                //VERIFY
                Assert.Equal("Todo App - TodoWebApp", driver.Title);
                Assert.Equal("https://localhost:44346/", driver.Url);
            }
        }
    }
}
