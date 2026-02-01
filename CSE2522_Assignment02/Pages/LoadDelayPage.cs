using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
	public class LoadDelayPage
	{
		private IWebDriver driver;

		public LoadDelayPage(IWebDriver driver)
		{
			this.driver = driver;
		}

		private IWebElement Button => driver.FindElement(By.Id("btn"));

		public void ClickButton() => Button.Click();

		public bool IsButtonDisplayed() => Button.Displayed;
	}
}

