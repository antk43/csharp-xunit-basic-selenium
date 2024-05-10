# csharp-xunit-basic-selenium

This solution contains a basic test project for testing a web frontend.

## xUnit
The project uses the [xUnit](https://xunit.net/) Test Framework - see [Microsoft: Unit testing C# in .NET 
using dotnet test and xUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test) - as the main testing tool.

## Selenium WebDriver
[Selenium WebDriver](https://www.selenium.dev/documentation/webdriver/) is used to drive and interact with the web browser.
A Selenium WebDriver instance of a browser is slightly different to the standard versions of browsers so a test project wanting to interact with a browser requires a `WebDriver` version of the respective browser.
The `WebDriver` version can be incorporated into your test project in one of two ways:
- downloaded ([e.g. ChromeDriver](https://chromedriver.chromium.org/downloads)) and stored locally within the test project 
- the more common approach is to consume a `WebDriver` package through a `Package Manager` ([e.g. NuGet: ChromeDriver](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/))

## Shared/Test Context
xUnit offers several methods for sharing setup and cleanup of code and we can utilise this for setting up and disposing of our WebDriver instances.

Without this we would be starting a new instance of a web browser for every single test and each browser instance would then remain open and not be closed down. The tests would be slower and more expensive to execute as a result.

Through utilising `Shared Context` we can easily manage our tests.

## Test Class
A very simple test class exists within the project which navigates to a specified URL and asserts that an expected element is displayed on the page.

The class uses the `Shared/Test Context` through the use of `IClassFixture<>`; this class fixture will access the fixture instance provided - `<WebDriverContext>`.
