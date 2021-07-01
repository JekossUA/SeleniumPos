using OpenQA.Selenium;

namespace POS.Helpers
{
    public class CustomControls : DriverHelper
    {
        public static void setInputValue(string elementXpath, string value) => Driver.FindElement(By.XPath(elementXpath)).SendKeys(value);

        public static IWebElement getElementXpath(string elementXpath) => Driver.FindElement(By.XPath(elementXpath));

        public static void waitElement(string elementXpath) => Wait.Until(e => e.FindElement(By.XPath(elementXpath)));

        public static void waitElementToBeClickable (string elementXpath) => Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.XPath(elementXpath)));

    }
}
