using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Assignment2.Pages
{
	public class LoginPage
	{
		private IWebDriver driver;

		public LoginPage(IWebDriver driver)
		{
			this.driver = driver;

		}

		//Login Validation
		public bool clickUserPassword()
		{
			By submit = By.XPath("/html/body/div/div/div/div/section/form/div[5]/button");



			driver.FindElement(By.CssSelector("#Input_Email")).SendKeys("admin@microsoft.com");
			driver.FindElement(By.CssSelector("#Input_Password")).SendKeys("Pass@word1");
			
			string eMAIL_Name = driver.FindElement(By.CssSelector("#Input_Email")).GetAttribute("value").ToString();
			string password = driver.FindElement(By.CssSelector("#Input_Password")).GetAttribute("value").ToString();

			if (eMAIL_Name == "admin@microsoft.com" && password == "Pass@word1")
			{
				WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(20));
				wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(submit));

				driver.FindElement(submit).Click();
				return true;
			}

			return false;
			
		}

		
	}
}
