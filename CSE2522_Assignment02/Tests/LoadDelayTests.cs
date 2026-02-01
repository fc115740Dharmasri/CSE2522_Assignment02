using CSE2522_Assignment02.Base;
using CSE2522_Assignment02.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace CSE2522_Assignment02.Tests
{
	[TestFixture]
	public class LoadDelayTests : TestBase
	{
		[Test]
		public void TC009_LoadDelay_ButtonAppears()
		{
			driver.Navigate().GoToUrl("https://uitestingplayground.com/loaddelay");

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			
			wait.Until(d => d.FindElements(By.Id("btn")).Count > 0 && d.FindElement(By.Id("btn")).Displayed);

			LoadDelayPage load = new LoadDelayPage(driver);
			Assert.That(load.IsButtonDisplayed(), Is.True, "Load delay button did not appear");
			load.ClickButton();
		}
	}
}

