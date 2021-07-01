using OpenQA.Selenium;
using POS.Helpers;


namespace POS.Pages
{
    public class SingOnPage : DriverHelper
    {
       
        IWebElement txtUsername => Driver.FindElement(By.XPath("//input[@id='username']"));
        IWebElement txtPassword => Driver.FindElement(By.XPath("//input[@id='password']"));
        IWebElement btnSingOn => Driver.FindElement(By.XPath("//button[@value='login']"));

        public void waitUsername() 
        {
            Wait.Until(e => txtUsername);
        } 

        public void enterUserNameAndPassword(string username, string password)
        {
            txtUsername.SendKeys(username);
            txtPassword.SendKeys(password);
        }

        public void clickSingOn()
        {
            btnSingOn.Click();
        }

    }
}
