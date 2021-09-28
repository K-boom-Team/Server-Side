using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCoreDeemo
{
    public class Tests
    {

        // Hooks in NUnit
        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test1()
        {
            // Browser driver
            IWebDriver webDriver = new ChromeDriver();

            //Navigate to site
            webDriver.Navigate().GoToUrl("http://localhost:8080/");

            //Identify Menu
            IWebElement lnkMenu = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button"));
            lnkMenu.Click();

            //Identify Users
            //IWebElement lnkUser = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div[2]/nav/div[1]/div/div[1]/div[2]/a[1]"));
            IWebElement lnkUser = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div[2]/nav/div[1]/div/div[1]/div[2]/a[1]/div[1]"));
            lnkUser.Click();
            
            //Identify Customers
            lnkMenu.Click();
            IWebElement lnkCustomers = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div[2]/nav/div[1]/div/div[1]/div[2]/a[2]"));
            lnkCustomers.Click();
            
            
             //Input customers data
             IWebElement lnkNewCustomer = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div/main/div/div/div/header/div/button"));
             lnkNewCustomer.Click();

             IWebElement inputNewCustomerDescrip = webDriver.FindElement(By.Id("input-109"));
             inputNewCustomerDescrip.SendKeys("This is description 1");
             IWebElement inputNewCustomerUserId = webDriver.FindElement(By.Id("input-112"));
             inputNewCustomerUserId.SendKeys("1");

             IWebElement lnkNewCustomerSave = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div[3]/div/div/div[3]/button[2]"));
             lnkNewCustomerSave.Click();

             inputNewCustomerDescrip.SendKeys("This is description 2");
             inputNewCustomerUserId.SendKeys("2");
             lnkNewCustomerSave.Click();
             inputNewCustomerDescrip.SendKeys("This is description 3");
             inputNewCustomerUserId.SendKeys("3");
             lnkNewCustomerSave.Click();
             inputNewCustomerDescrip.SendKeys("This is description 4");
             inputNewCustomerUserId.SendKeys("4");
             lnkNewCustomerSave.Click();


             //Identify Specialists
             lnkMenu.Click();
             IWebElement lnkSpecialists = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div[2]/nav/div[1]/div/div[1]/div[2]/a[3]"));
             lnkSpecialists.Click();

             //Input specialists data
             IWebElement lnkNewSpecialist = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div[1]/main/div/div/div/header/div/button"));
             lnkNewSpecialist.Click();

             IWebElement inputNewSpecialistUserId = webDriver.FindElement(By.Id("input-199"));
             inputNewSpecialistUserId.SendKeys("1");
             IWebElement inputNewSpecialistSpecialty = webDriver.FindElement(By.Id("input-202"));
             inputNewSpecialistSpecialty.SendKeys("Specialty 1");

             IWebElement lnkNewSpecialistSave = webDriver.FindElement(By.XPath("//*[@id=\"inspire\"]/div[3]/div/div/div[3]/button[2]"));
             lnkNewSpecialistSave.Click();

             inputNewSpecialistUserId.SendKeys("2");
             inputNewSpecialistSpecialty.SendKeys("Specialty 2");
             lnkNewSpecialistSave.Click();
             inputNewSpecialistUserId.SendKeys("3");
             inputNewSpecialistSpecialty.SendKeys("Specialty 3");
             lnkNewSpecialistSave.Click();
             inputNewSpecialistUserId.SendKeys("4");
             inputNewSpecialistSpecialty.SendKeys("Specialty 4");
             lnkNewSpecialistSave.Click();
             
        }

    }
}