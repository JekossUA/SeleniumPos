using OpenQA.Selenium;
using POS.Helpers;

namespace POS.Pages 
{
    // $x("//div[@class='pos-cards']//button[@value='posNo:200']") - xpath to find element from colsole
    public class PosPage : DriverHelper
    {

        IWebElement txtArticlePanel => Driver.FindElement(By.XPath("//div[@class='articles-items']"));

        public void waitArticlePanel() => Wait.Until(e => txtArticlePanel);

        public bool isVisibleArticlePanel() 
        {
            if (Wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(txtArticlePanel)) != null)
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
