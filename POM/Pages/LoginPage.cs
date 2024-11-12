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
        private By Username => By.Id("user-name");
        private By Password => By.Id("password");
        private By LoginButton => By.Id("login-button");
        private By ErrorContainer => By.CssSelector(".error-message-container");
        
    }
}
