using OpenQA.Selenium;
using POS.Variables;

namespace POS.Pages 
{
    // $x("//div[@class='pos-cards']//button[@value='posNo:200']") - xpath to find element from colsole
    public class LoginPage : DriverHelper
    {
        public static readonly string username_input = "//input[@id='username']";
        public static readonly string password_input = "//input[@id='password']";
        public static readonly string login_button = "//button[@value='login']";
        public static readonly string pos_button = "//div[@class='pos-cards']//button[@value='posNo:200']";


        public static void setInputValue( string elementXpath, string value)
        {
             Driver.FindElement(By.XPath(elementXpath)).SendKeys(value);
        }

        public static IWebElement getElementXpath(string elementXpath)
        {
            return Driver.FindElement(By.XPath(elementXpath));
        }

    }    
}
