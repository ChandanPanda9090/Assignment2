using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2.Pages
{
	public class CheackOut
	{
		private IWebDriver driver;

		public CheackOut(IWebDriver driver)
		{
			this.driver = driver;
		}

		//By continueshoping = By.XPath("//a[text()='[ Continue Shopping ]']");

		//By final = By.XPath("/html/body/div/div/form/div/div[3]/section[2]/a");


		

		public Payment againshopping() 
		{
			driver.FindElement(By.XPath("(//*[@class='btn esh-basket-checkout'])[2]")).Click();
			((IJavaScriptExecutor)driver).ExecuteScript("window.scrollTo(0,document.body.scrollHeight)");
			Thread.Sleep(2000);
			return new Payment(driver);
			
		}


	}
}
