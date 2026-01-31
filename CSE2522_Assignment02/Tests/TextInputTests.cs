using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
	[TestFixture]
	public class TextInputTests : TestBase
	{
		[Test]
		public void TC001_1_Text_Input_Verification()
		{
			HomePage homePage = new HomePage(driver);
			TextInputPage textInputPage = new TextInputPage(driver);

			homePage.GoToTextInputPage();

			Assert.That(
				textInputPage.IsTextBoxDisplayed(),
				Is.True,
				"Text box is not displayed"
			);

			Assert.That(
				textInputPage.IsButtonDisplayed(),
				Is.True,
				"Button is not displayed"
			);

			string inputText = "CSE2522 Test";
			textInputPage.EnterText(inputText);
			textInputPage.ClickButton();

			Assert.That(
				textInputPage.GetButtonText(),
				Is.EqualTo(inputText),
				"Button text did not update correctly"
			);
		}
	}
}
