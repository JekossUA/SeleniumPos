using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using POS.Helpers;
using POS.Pages;
using System;

namespace POS
{
    public class LoginQA1 : DriverHelper
    {
        Credentials creds = new Credentials();
        

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(Credentials.time_in_seconds));
            Driver.Navigate().GoToUrl(Environments.qa1);
            Driver.Manage().Window.Maximize();
            
        }

        [Test]
        public void Test1()
        {
            try
            {
                CustomControls.waitElement(SingOnPage.username_input);

                CustomControls.setInputValue(SingOnPage.username_input, Credentials.username);
                CustomControls.setInputValue(SingOnPage.password_input, Credentials.password);
                CustomControls.getElementXpath(SingOnPage.login_button).Click();

                CustomControls.waitElement(StationsPage.pos_button);

                CustomControls.getElementXpath(StationsPage.pos_button).Click();

                CustomControls.waitElementToBeClickable(PosPage.article_items);

                

                Driver.Close();

            }
            catch (Exception)
            {
                throw;
            }
            

        }
    }
}