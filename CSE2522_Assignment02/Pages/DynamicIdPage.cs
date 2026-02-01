using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
	public class DynamicIdPage
	{
		private IWebDriver driver;

		public DynamicIdPage(IWebDriver driver)
		{
			this.driver = driver;
		}

		// Use stable XPath instead of ID
		private IWebElement DynamicButton =>
			driver.FindElement(By.XPath("//button[text()='Button with Dynamic ID']"));

		public void ClickDynamicButton()
		{
			DynamicButton.Click();
		}

		public bool IsButtonDisplayed()
		{
			return DynamicButton.Displayed;
		}
	}
}
