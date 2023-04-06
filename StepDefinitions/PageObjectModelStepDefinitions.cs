
using Assignment2.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools;

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

		[Given(@"Enter Login Page")]
		public void GivenEnterTheYoutubeURL()
		{
			driver.Url = "https://localhost:44315/";
			Thread.Sleep(3000);

			HomePage homePage = new HomePage(driver);
			homePage.clickOnIndex();

			Thread.Sleep(3000);


		}

		[When(@"Enter login Userid and Pasword")]
		public void WhenSearchForTheTestersTalkInYoutube()
		{

			LoginPage login = new LoginPage(driver);
			bool success=login.clickUserPassword();

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
		public void Navigatetohome()
		{
			CheackOut cheackOut = new CheackOut(driver);
			cheackOut.againshopping();


		}

		[When(@"Navigate to details")]
		public void Navigatetodetailsl()
		{
			Payment payment = new Payment(driver);
			payment.bill();


		}


	}
}