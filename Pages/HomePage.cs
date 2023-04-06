using OpenQA.Selenium;
using OpenQA.Selenium.DevTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Pages

{ 

	public class HomePage
	{
		


		private IWebDriver driver;

		public HomePage(IWebDriver driver)
		{
			this.driver = driver;
		}


		//click login
		By login = By.CssSelector(".esh-identity-name");
		



		

		By ConinueShopp = By.XPath("//*[@class='btn esh-basket-checkout text-white']");
		By BlackShirt = By.XPath("((//img[@class='esh-catalog-thumbnail'])[1]/parent::form/input)[1]");		
		By Catalog = By.CssSelector(".esh-catalog-item.col-md-4");
		By allpname = By.CssSelector(".esh-catalog-name");
		By BrandName = By.XPath("(//option[@value='2'])[1]");
		By Type = By.XPath(".//*[@id='CatalogModel_TypesFilterApplied']");
		By TypeName = By.XPath("(//option[@value='1'])[2]");
		By Apply = By.XPath(".//*[@class='esh-catalog-send']");
		By Add = By.XPath("(//*[@class='esh-catalog-button'])");


		//click login
		public LoginPage clickOnIndex()
		{
			Thread.Sleep(3000);
			driver.FindElement(login).Click();
			Thread.Sleep(3000);

			return new LoginPage(driver);
		}


		public CheackOut item()
		{

			string[] expectedProduct = { ".NET BOT BLACK SWEATSHIRT", ".NET BLACK & WHITE MUG", "PRISM WHITE T-SHIRT" };
			string[] productName;

			IList<IWebElement> list = driver.FindElements(By.CssSelector(".esh-catalog-item.col-md-4"));
			IList<IWebElement> name = driver.FindElements(By.CssSelector(".esh-catalog-name"));

			foreach (IWebElement element in list)
			{
				driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
				if (expectedProduct.Contains(element.FindElement(allpname).Text)) 
				{
					driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);					
					element.FindElement(Add).Click();
					Thread.Sleep(3000);

				}
				break;
			}


			 ((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(1000);

			driver.FindElement(ConinueShopp).Click();

			driver.FindElement(BlackShirt).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			driver.FindElement(Catalog).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			driver.FindElement(allpname).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			driver.FindElement(BrandName).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			driver.FindElement(Type).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			driver.FindElement(TypeName).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			driver.FindElement(Apply).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			driver.FindElement(Add).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);



			return new CheackOut(driver);
		}






		


	}
}
