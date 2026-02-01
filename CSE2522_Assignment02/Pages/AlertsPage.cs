using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace CSE2522_Assignment02.Pages
{
	public class AlertsPage
	{
		private readonly IWebDriver driver;
		private readonly WebDriverWait wait;

		private readonly By alertsLink = By.LinkText("Alerts");
		private readonly By alertButton = By.Id("alertButton");
		private readonly By confirmButton = By.Id("confirmButton");
		private readonly By promptButton = By.Id("promptButton");

		public AlertsPage(IWebDriver driver)
		{
			this.driver = driver;
			wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
		}

		public void Open()
		{
			driver.FindElement(alertsLink).Click();
		}

		public void ClickAlert()
		{
			driver.FindElement(alertButton).Click();
			wait.Until(ExpectedConditions.AlertIsPresent());
		}

		public void ClickConfirm()
		{
			driver.FindElement(confirmButton).Click();
			wait.Until(ExpectedConditions.AlertIsPresent());
		}

		public void ClickPrompt()
		{
			driver.FindElement(promptButton).Click();
			wait.Until(ExpectedConditions.AlertIsPresent());
		}

		public string GetAlertText()
		{
			return driver.SwitchTo().Alert().Text;
		}

		public void AcceptAlert()
		{
			driver.SwitchTo().Alert().Accept();
		}

		public void SendTextToAlert(string text)
		{
			driver.SwitchTo().Alert().SendKeys(text);
		}
	}
}
