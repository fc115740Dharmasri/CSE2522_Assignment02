using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
	public class AlertsPage
	{
		private IWebDriver driver;

		public AlertsPage(IWebDriver driver) => this.driver = driver;

		private IWebElement AlertBtn => driver.FindElement(By.Id("alertButton"));
		private IWebElement ConfirmBtn => driver.FindElement(By.Id("confirmButton"));
		private IWebElement PromptBtn => driver.FindElement(By.Id("promptButton"));
		private IWebElement Output => driver.FindElement(By.Id("output"));

		public void TriggerAlert() => AlertBtn.Click();
		public void TriggerConfirm() => ConfirmBtn.Click();
		public void TriggerPrompt() => PromptBtn.Click();
		public string GetOutputText() => Output.Text;
	}
}
