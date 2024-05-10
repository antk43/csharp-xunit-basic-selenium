# csharp-xunit-basic-selenium

This solution contains a basic test project for testing a web frontend.

## xUnit
The project uses the [xUnit](https://xunit.net/) Test Framework - see [Microsoft: Unit testing C# in .NET 
using dotnet test and xUnit](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test) - as the main testing tool.

## Selenium WebDriver
[Selenium WebDriver](https://www.selenium.dev/documentation/webdriver/) is used to drive and interact with the web browser.

A Selenium WebDriver instance of a browser is different to the standard versions of browsers. 
A test project wanting to interact with a browser requires a `WebDriver` version of the respective browser.


The `WebDriver` version can be incorporated into your test project in one of two ways:
- downloaded ([ChromeDriver](https://chromedriver.chromium.org/downloads), [Firefox WebDriver](https://github.com/mozilla/geckodriver/releases), [Edge WebDriver](https://developer.microsoft.com/en-us/microsoft-edge/tools/webdriver/?form=MA13LH)) and stored locally within the test project 
- the more common approach is to consume a `WebDriver` package through a `Package Manager` ([e.g. NuGet: ChromeDriver](https://www.nuget.org/packages/Selenium.WebDriver.ChromeDriver/))

A new instance of the browser is simply initialised by using the [C# new operator](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/operators/new-operator) - `ChromeDriver = new ChromeDriver()`.

A WebDriver instance will remain open unless it is told to end. We dispose of the WebDriver using the shared context outlined below. 

## Shared/Test Context
xUnit offers several methods for sharing setup and cleanup of code and we can utilise this for setting up and disposing of our WebDriver instances.

Without a shared context any test execution would be slow and process intensive as WebDriver startup and dispose code would be ran for every single test.

The shared context is located within the `WebDriverContext` class.



## Test Class
A very simple test class exists within the project which navigates to a specified URL and asserts that an expected element is displayed on the page.

The class uses the `Shared/Test Context` through the use of `IClassFixture<>`; this class fixture will access the fixture instance provided - `<WebDriverContext>`.
