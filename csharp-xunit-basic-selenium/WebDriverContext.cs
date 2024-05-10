using OpenQA.Selenium.Chrome;

namespace csharp_xunit_basic_selenium
{

    /*
     * This is the XUnit test context. It will be executed each time a test is run if the calling class
     * is decorated with the ICollectionFixture<>.
     */

    public class WebDriverContext : IDisposable
    {
        public ChromeDriver ChromeDriver { get; private set; }

        public WebDriverContext()
        {
            ChromeDriver = new ChromeDriver();
        }

        public void Dispose()
        {
            if (ChromeDriver != null)
            {
                ChromeDriver.Quit();
                ChromeDriver = null!;
            }
        }
    }
}