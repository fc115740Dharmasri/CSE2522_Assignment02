using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
	[TestFixture]
	public class ClickTests : TestBase
	{
		[Test]
		public void TC002_Click_Button_Verification()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/click");

			ClickPage clickPage = new ClickPage(driver);

			clickPage.ClickButtonAction();

			// After click, class attribute changes to "btn-success"
			Assert.That(
				clickPage.GetButtonClass().Contains("btn-success"),
				Is.True,
				"Button was not clicked successfully"
			);
		}
	}
}
