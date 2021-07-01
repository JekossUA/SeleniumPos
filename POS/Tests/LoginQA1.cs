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
            SingOnPage singOnPage = new SingOnPage();
            StationsPage stationsPage = new StationsPage();
            PosPage posPage = new PosPage();

            try
            {
               
                singOnPage.waitUsername();
                singOnPage.enterUserNameAndPassword("ym", "ym");
                singOnPage.clickSingOn();

                stationsPage.waitPosButton();
                stationsPage.clickStationButton();

                posPage.waitArticlePanel();

                Assert.That(posPage.isVisibleArticlePanel(), Is.True);
                
            }
            catch (Exception)
            {
                throw;
            }
            

        }
        [TearDown]
        public void closeBrowser()
        {
            Driver.Close();
        }
    }
}