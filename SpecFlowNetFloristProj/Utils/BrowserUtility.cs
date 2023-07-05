using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace SpecFlowNetFloristProj.Utils
{
    public class BrowserUtility
    {
        public IWebDriver init(IWebDriver driver)
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://stage2.netflorist.co.za/";
            return driver;
        }
    }
}
