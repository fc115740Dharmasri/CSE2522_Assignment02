using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
	[TestFixture]
	public class DynamicIdTests : TestBase
	{
		[Test]
		public void TC003_Dynamic_ID_Button_Verification()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/dynamicid");

			DynamicIdPage dynamicIdPage = new DynamicIdPage(driver);

			Assert.That(
				dynamicIdPage.IsButtonDisplayed(),
				Is.True,
				"Dynamic ID button is not displayed"
			);

			dynamicIdPage.ClickDynamicButton();
		}
	}
}

