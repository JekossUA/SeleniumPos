using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using POS.Variables;
using POS.Pages;
using System;

namespace POS
{
    public class LoginQA1 : DriverHelper
    {
        Environments envs = new Environments();
        Credentials creds = new Credentials();
        

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(creds.time_in_seconds));
            Driver.Navigate().GoToUrl(envs.qa1);
            Driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void Test1()
        {
            Wait.Until(e => e.FindElement(By.XPath(LoginPage.username_input)));

            LoginPage.setInputValue(LoginPage.username_input, creds.username);
            LoginPage.setInputValue(LoginPage.password_input, creds.password);
            LoginPage.getElementXpath(LoginPage.login_button).Click();

            Wait.Until(e => e.FindElement(By.XPath(LoginPage.pos_button)));

            LoginPage.getElementXpath(LoginPage.pos_button).Click();


        }
    }
}