
using Assignment2.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;
using TechTalk.SpecFlow.Assist;

namespace Assignment2.StepDefinitions
{
	[Binding]
	public sealed class PageObjectModelStepDefinitions
	{
		private IWebDriver driver;
		
		LoginPage? loginpage= null;

		public PageObjectModelStepDefinitions(IWebDriver driver)
		{
			this.driver = driver;

		}

		[Given(@"I lunch the application")]
		public void GivenEnterTheYoutubeURL()
		{
			driver.Url = "https://localhost:44315/";
			Thread.Sleep(3000);

		}


		//[When(@"click on login button")]
		//public void WhenClickOnLoginButton()
		//{
		//	HomePage homePage = new HomePage(driver);
		//	homePage.clickOnIndex();
		//}


		[When(@"click on login button")]
		public void WhenClickOnLoginButton()
		{
			HomePage homePage = new HomePage(driver);
				homePage.clickOnIndex();
		}



		[When(@"Enter the login details  '([^']*)' and '([^']*)'")]
		public void WhenEnterTheLoginDetailsAnd(string p0, string p1)
		{
			LoginPage login = new LoginPage(driver);
			bool success = login.clickUserPassword();

			Thread.Sleep(3000);

			if (success)
			{
				HomePage homePage = new HomePage(driver);
				homePage.item();

				Thread.Sleep(3000);
			}
			else
			{
				return;
			}
		}

		[When(@"Navigate to home")]
		public void WhenNavigateToHome()
		{
			HomePage homePage = new HomePage(driver);
			homePage.item();

		}



		[When(@"Add item")]
		public void Navigatetodetailsl()
		{
			Payment payment = new Payment(driver);
			payment.bill();


		}


	}
}