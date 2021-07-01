using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace POS.Helpers
{
    public class DriverHelper
    {
        public static IWebDriver Driver { get; set; }

        public static WebDriverWait Wait { get; set; }
    }
}
