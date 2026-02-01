using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
	public class ClickPage
	{
		private IWebDriver driver;

		public ClickPage(IWebDriver driver)
		{
			this.driver = driver;
		}

		private IWebElement ClickButton =>
			driver.FindElement(By.Id("badButton"));

		public void ClickButtonAction()
		{
			ClickButton.Click();
		}

		public string GetButtonClass()
		{
			return ClickButton.GetAttribute("class");
		}
	}
}
