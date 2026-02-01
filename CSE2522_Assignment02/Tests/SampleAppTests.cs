using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
	[TestFixture]
	public class SampleAppTests : TestBase
	{
		[Test]
		public void TC004_SampleApp_Login_Success()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/sampleapp");

			SampleAppPage sampleApp = new SampleAppPage(driver);
			sampleApp.Login("User", "pwd");

			Assert.That(
				sampleApp.GetLoginMessage().Contains("Welcome"),
				Is.True,
				"Login success message not displayed"
			);
		}

		[Test]
		public void TC005_SampleApp_Login_Failure()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/sampleapp");

			SampleAppPage sampleApp = new SampleAppPage(driver);
			sampleApp.Login("wrong", "wrong");

			Assert.That(
				sampleApp.GetLoginMessage().Contains("Invalid"),
				Is.True,
				"Login failure message not displayed"
			);
		}
	}
}
