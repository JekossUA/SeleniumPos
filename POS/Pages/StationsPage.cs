using OpenQA.Selenium;
using POS.Helpers;


namespace POS.Pages
{
    public class StationsPage : DriverHelper
    {
        
        IWebElement txtStationButton => Driver.FindElement(By.XPath("//div[@class='pos-cards']//button[@value='posNo:200']"));

        public void waitPosButton() => Wait.Until(e => txtStationButton);

        public void clickStationButton() => txtStationButton.Click();

    }
}
