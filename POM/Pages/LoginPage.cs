using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POM.Pages
{
    public class LoginPage
    {
        // Method to locate username field
        public IWebElement UsernameField => _driver.FindElement(Username);

        // Method to locate password field
        public IWebElement PasswordField => _driver.FindElement(Password);

        // Method to locate login button
        public IWebElement LoginButton => _driver.FindElement(LoginButton);

        // Method to locate error message container
        public IWebElement ErrorContainer => _driver.FindElement(ErrorContainer);
        
    }
}
