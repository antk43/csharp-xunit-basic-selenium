using OpenQA.Selenium;
using Xunit;

namespace csharp_xunit_basic_selenium
{
    /*
     * This is a test class within the collection and uses the test context with IClassFixture<>.
     */

    public class Test : IClassFixture<WebDriverContext>
    {
        private readonly WebDriverContext driverContext;

        public Test(WebDriverContext driverContext)
        {
            this.driverContext = driverContext;
        }

        [Fact]
        public void TestChromeDriver()
        {
            driverContext.ChromeDriver.Navigate().GoToUrl("http://microsoft.com");
            var a = driverContext.ChromeDriver.FindElement(By.CssSelector("#uhfLogo"));
            Assert.Equal("Microsoft", a.Text.ToString());
        }
    }
}
