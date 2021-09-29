using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace TerapicFisicalHelper.Cucumber.Steps
{
    [Binding]
    public class US0001StepDefs
    {
        public static IWebDriver webDriver;
        public static WebDriverWait wait;

        //SCENARIO 1
        public US0001StepDefs()
        {
            webDriver = new ChromeDriver();
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        [Given(@"que el usuario ha ingresado a la aplicación y se encuentra en la vista inicio")]
        public void GivenQueElUsuarioHaIngresadoALaAplicacionYSeEncuentraEnLaVistaInicio()
        {
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app/");
            webDriver.Manage().Window.Maximize();
        }
        
        [When(@"selecciona la opción Nuevo Usuario")]
        public void WhenSeleccionaLaOpcionNuevoUsuario()
        {
            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webUser = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[1]")));
            webUser.Click();
        }
        
        [Then(@"se muestra la vista de registo")]
        public void ThenSeMuestraLaVistaDeRegisto()
        {
            WebDriverWait espera = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }


        //SCENARIO 2
        [Given(@"que el usuario se encuentra en la vista nuevo Usuario")]
        public void GivenQueElUsuarioSeEncuentraEnLaVistaNuevoUsuario()
        {
            IWebElement newUser = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/main/div/div/div/header/div/button")));
            newUser.Click();
        }

        [When(@"ingresa sus datos y da clic en guardar")]
        public void WhenIngresaSusDatosYDaClicEnGuardar()
        {
            IWebElement userName = wait.Until(e => e.FindElement(By.Id("user-name")));
            userName.SendKeys("Luis");

            IWebElement userLastName = wait.Until(e => e.FindElement(By.Id("user-lastname")));
            userLastName.SendKeys("Mendez");

            IWebElement userDescription = wait.Until(e => e.FindElement(By.Id("user-description")));
            userDescription.SendKeys("Me gusta hacer deporte");

            IWebElement userBirth = wait.Until(e => e.FindElement(By.Id("user-birth")));
            userBirth.SendKeys("11/11/1990");

            IWebElement userAddress = wait.Until(e => e.FindElement(By.Id("user-address")));
            userAddress.SendKeys("Avenida La Alameda");

            IWebElement userPhone = wait.Until(e => e.FindElement(By.Id("user-phone")));
            userPhone.SendKeys("966314855");

            IWebElement userAge = wait.Until(e => e.FindElement(By.Id("user-age")));
            userAge.SendKeys("31");

            IWebElement userEmail = wait.Until(e => e.FindElement(By.Id("user-email")));
            userEmail.SendKeys("luis.mendez@gmail.com");

            IWebElement userCountry = wait.Until(e => e.FindElement(By.Id("user-country")));
            userCountry.SendKeys("Perú");

            IWebElement userGender = wait.Until(e => e.FindElement(By.Id("user-gender")));
            userGender.SendKeys("maculino");

            IWebElement userPassword = wait.Until(e => e.FindElement(By.Id("user-password")));
            userPassword.SendKeys("rfLNWwn8");

            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("user-save")));
            btnSave_U.Click();
        }

        [Then(@"se crea la cuenta del usuario")]
        public void ThenSeCreaLaCuentaDelUsuario()
        {
            WebDriverWait espera = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

    }
}
