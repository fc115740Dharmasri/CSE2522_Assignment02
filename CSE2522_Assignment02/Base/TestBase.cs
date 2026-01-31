using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace CSE2522_Assignment02.Base
{
	public class TestBase
	{
		protected IWebDriver driver;

		[SetUp]
		public void SetUp()
		{
			ChromeOptions options = new ChromeOptions();
			options.AddArgument("--ignore-certificate-errors");
			options.AddArgument("--allow-insecure-localhost");
			options.AddArgument("--disable-notifications");

			driver = new ChromeDriver(options);
			driver.Manage().Window.Maximize();
			driver.Navigate().GoToUrl("https://uitestingplayground.com/");
		}

		[TearDown]
		public void TearDown()
		{
			if (driver != null)
			{
				driver.Quit();
				driver.Dispose();
			}
		}
	}
}


