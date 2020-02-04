using System;
using System.Collections.Generic;
using System.Text;
using AventStack.ExtentReports;
using SeleniumProject.Configuration;
using SeleniumProject.Helpers;
using SeleniumProject.Infra.Pages;

namespace SeleniumProject.Process
{
    class LogProcess
    {


        public static Dictionary<string, Status> LoginToNess()
        {
            Dictionary<string, Status> result = new Dictionary<string, Status>();
            LogIn LI = new LogIn();
            result.Add("Navigate To Home Page", LI.NavigateToHomePage());
            result.Add("Insert User", LI.InsertUser(Configuration.Configuration.UserName));
            result.Add("Insert Password", LI.InsertPassword(Configuration.Configuration.Password));
            result.Add("Click Enter", LI.ClickEnter());
            return result;
        }

    }
}
