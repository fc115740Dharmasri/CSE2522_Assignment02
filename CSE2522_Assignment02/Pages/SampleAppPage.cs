using OpenQA.Selenium;

namespace CSE2522_Assignment02.Pages
{
	public class SampleAppPage
	{
		private IWebDriver driver;

		public SampleAppPage(IWebDriver driver)
		{
			this.driver = driver;
		}

		private IWebElement Username =>
			driver.FindElement(By.Name("UserName"));

		private IWebElement Password =>
			driver.FindElement(By.Name("Password"));

		private IWebElement LoginButton =>
			driver.FindElement(By.Id("login"));

		private IWebElement Message =>
			driver.FindElement(By.Id("loginstatus"));

		public void Login(string username, string password)
		{
			Username.Clear();
			Username.SendKeys(username);
			Password.Clear();
			Password.SendKeys(password);
			LoginButton.Click();
		}

		public string GetLoginMessage()
		{
			return Message.Text;
		}
	}
}
