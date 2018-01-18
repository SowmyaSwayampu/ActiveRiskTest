using System;
using NUnit.Framework;
using OpenQA.Selenium;


namespace ParllelSeleniumNUnitTest
{
    [TestFixture]
    public class ActiveRisk : Hooks
    {
        [Test]
        //Search for the word Risk Management in the website
        public void RiskManagement_Search()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Risk Management");
                Driver.FindElement(By.Id("searchsubmit")).Click();   
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());  
            }
        }
        [Test]
        //Validate whether the page showing correct results
        public void RiskManagement_Validate()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Risk Management");
                Driver.FindElement(By.Id("searchsubmit")).Click();
                String Page_Title = "Risk Management";
                Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains(Page_Title));
            }
            catch(Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());
            }
        }
        [Test]
        //Vefiry the loaded page is correct or not
        public void RiskManagement_LoadCorrectPage()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Risk Management");
                Driver.FindElement(By.Id("searchsubmit")).Click();
                Assert.That(Driver.PageSource.Contains("Risk Management"), Is.EqualTo(true), "the text Risk management doesnot exit");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());
            }
        }
        [Test]
        //Check the following results are working or not
        public void RiskManagement_CheckLink()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Risk Management");
                Driver.FindElement(By.Id("searchsubmit")).Click();
                Driver.FindElement(By.XPath(".//*[@id='post-9517']/h3/a/time")).Click();               
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());
            }
        }
        [Test]
        //Search for Leverage in the website
        public void Leverage_Search()
        {
            try
            {              
                Driver.FindElement(By.Name("s")).SendKeys("Leverage");
                Driver.FindElement(By.Id("searchsubmit")).Click();                
            }
            catch(Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());              
            }
        }
        [Test]
        //Validate whether the page showing correct results
        public void Leverage_Validate()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Leverage");
                Driver.FindElement(By.Id("searchsubmit")).Click();
                String Page_Title = "Leverage";
                Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains(Page_Title));                
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Validation Failed " + ex.ToString());
            }
        }
        [Test]
        //Vefiry the loaded page is correct or not
        public void Leverage_LoadCorrectPage()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Leverage");
                Driver.FindElement(By.Id("searchsubmit")).Click();
                Assert.That(Driver.PageSource.Contains("Leverage"), Is.EqualTo(true), "the text Leverage doesnot exit");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());
            }
        }
        [Test]
        //Search for the word Compatability in the website
        public void Compatibility_Search()
        {
            try
            {             
                Driver.FindElement(By.Name("s")).SendKeys("Compatibility");
                Driver.FindElement(By.Id("searchsubmit")).Click();                             
            }
            catch(Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());                
            }            
        }
        [Test]
        //Validate whether the page showing correct results
        public void Compatibility_Validate()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Compatibility");
                Driver.FindElement(By.Id("searchsubmit")).Click();
                String Page_Title = "Compatibility";
                Assert.IsTrue(Driver.FindElement(By.TagName("body")).Text.Contains(Page_Title));                
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"No Search Results found" + ex.ToString());                
            }
        }
        [Test]
        //Vefiry the loaded page is correct or not
        public void Compatibility_LoadCorrectPage()
        {
            try
            {
                Driver.FindElement(By.Name("s")).SendKeys("Compatibility");
                Driver.FindElement(By.Id("searchsubmit")).Click();
                Assert.That(Driver.PageSource.Contains("Compatibility"), Is.EqualTo(true), "Sorry, no results found! Please try again.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(@"Exception caught, test failed: " + ex.ToString());               
            }
        }
        [TearDown]

        public void TearDown()
        {
            Driver.Quit();
        }

    }
}
