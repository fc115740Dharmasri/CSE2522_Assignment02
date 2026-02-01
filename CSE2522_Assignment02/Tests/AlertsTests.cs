using NUnit.Framework;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;

namespace CSE2522_Assignment02.Tests
{
	public class AlertsTests : TestBase
	{
		private AlertsPage alertsPage;

		[SetUp]
		public void TestSetup()
		{
			alertsPage = new AlertsPage(driver);
			alertsPage.Open();
		}

		[Test]
		public void Alert_ShouldDisplayMessage()
		{
			alertsPage.ClickAlert();
			string text = alertsPage.GetAlertText();

			Assert.That(text, Does.Contain("Alert"));
			alertsPage.AcceptAlert();
		}

		[Test]
		public void ConfirmAlert_ShouldBeAccepted()
		{
			alertsPage.ClickConfirm();
			alertsPage.AcceptAlert();

			Assert.Pass("Confirm alert accepted successfully");
		}

		[Test]
		public void PromptAlert_ShouldAcceptInput()
		{
			string input = "Selenium";

			alertsPage.ClickPrompt();
			alertsPage.SendTextToAlert(input);
			alertsPage.AcceptAlert();

			Assert.Pass("Prompt alert handled successfully");
		}
	}
}

