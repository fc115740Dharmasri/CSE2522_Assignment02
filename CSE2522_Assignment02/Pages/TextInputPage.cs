using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
	public class TextInputPage
	{
		private IWebDriver driver;

		public TextInputPage(IWebDriver driver)
		{
			this.driver = driver;
		}

		private IWebElement TextBox =>
			driver.FindElement(By.Id("newButtonName"));

		private IWebElement Button =>
			driver.FindElement(By.Id("updatingButton"));

		public bool IsTextBoxDisplayed()
		{
			return TextBox.Displayed;
		}

		public bool IsButtonDisplayed()
		{
			return Button.Displayed;
		}

		public void EnterText(string text)
		{
			TextBox.Clear();
			TextBox.SendKeys(text);
		}

		public void ClickButton()
		{
			Button.Click();
		}

		public string GetButtonText()
		{
			return Button.Text;
		}
	}
}
