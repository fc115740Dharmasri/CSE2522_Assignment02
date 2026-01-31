using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
	public class HomePage
	{
		private IWebDriver driver;

		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
		}

		private IWebElement TextInputLink =>
			driver.FindElement(By.LinkText("Text Input"));

		public void GoToTextInputPage()
		{
			TextInputLink.Click();
		}
	}
}
