using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;
using System;

namespace CSE2522_Assignment02.Tests
{
	[TestFixture]
	public class AlertsTests : TestBase
	{
		[Test]
		public void TC006_Handle_Alert()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");
			AlertsPage alerts = new AlertsPage(driver);

			alerts.TriggerAlert();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
			wait.Until(d => {
				try { d.SwitchTo().Alert(); return true; }
				catch (NoAlertPresentException) { return false; }
			});

			IAlert a = driver.SwitchTo().Alert();
			a.Accept();

			Assert.That(alerts.GetOutputText().Contains("Alert"), Is.True, "Alert was not handled correctly");
		}

		[Test]
		public void TC007_Handle_Confirm()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");
			AlertsPage alerts = new AlertsPage(driver);

			alerts.TriggerConfirm();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
			wait.Until(d => {
				try { d.SwitchTo().Alert(); return true; }
				catch (NoAlertPresentException) { return false; }
			});

			IAlert a = driver.SwitchTo().Alert();
			a.Accept();

			Assert.That(alerts.GetOutputText().Contains("Ok"), Is.True, "Confirm was not accepted correctly");
		}

		[Test]
		public void TC008_Handle_Prompt()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/alerts");
			AlertsPage alerts = new AlertsPage(driver);

			alerts.TriggerPrompt();
			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
			wait.Until(d => {
				try { d.SwitchTo().Alert(); return true; }
				catch (NoAlertPresentException) { return false; }
			});

			IAlert a = driver.SwitchTo().Alert();
			a.SendKeys("TestAlert");
			a.Accept();

			Assert.That(alerts.GetOutputText().Contains("TestAlert"), Is.True, "Prompt input not handled correctly");
		}
	}
}

