using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;

namespace ParllelSeleniumNUnitTest
{
  
    [TestFixture]
    public class Hooks 
            
    {
       public IWebDriver Driver;
        [SetUp]
        public void InitializeTest()
        {
            //providing gecko driver reference
            FirefoxDriverService service = FirefoxDriverService.CreateDefaultService(@"C:/Users/");
            service.FirefoxBinaryPath = @"C:/Program Files (x86)/Mozilla Firefox/firefox.exe";
            Driver = new FirefoxDriver(service);
            Driver.Navigate().GoToUrl("http://www.sword-activerisk.com/");
         
        }
        
          
    }
}
