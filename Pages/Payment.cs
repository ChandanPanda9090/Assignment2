using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Pages
{
	public class Payment
	{
		private IWebDriver driver;

		public Payment(IWebDriver driver)
		{
			this.driver = driver;

		}


		//click pay button
		By pay = By.XPath("/html/body/div/div/form/div/div[3]/section[2]/input");


		public OrderConfirmation bill() 
		{
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(3000);

			WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
			wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(pay));
			driver.FindElement(pay).Click();
			
			return new OrderConfirmation(driver);
		}
	}
}
