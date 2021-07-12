using OpenQA.Selenium;
using POS.Helpers;

namespace POS.Pages 
{
    // $x("//div[@class='pos-cards']//button[@value='posNo:200']") - xpath to find element from colsole
    public class PosPage : DriverHelper
    {

        IWebElement txtAdminPanel => Driver.FindElement(By.XPath("//div[@class='admin-panel']"));
        IWebElement txtShiftStartButton => Driver.FindElement(By.XPath("//div[@id='button-shift-start']"));
        By txtArticlePanel => By.XPath("//div[@class='panel articles-panel']");

        public void waitAdminPanel() => Wait.Until(e => txtAdminPanel);
        public void waitShiftStartButton() => Wait.Until(e => txtShiftStartButton);
        public void waitArticlePanel() => Wait.Until(e => Driver.FindElement(txtArticlePanel));

        public bool isClickableAdminPanel() 
        {
            if (Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(txtAdminPanel)) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void clickShiftStartButton()
        {
            txtShiftStartButton.Click();
        }
        public bool isVisibleArticlePanel()
        {
            if (Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(txtArticlePanel)) != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }    
}
