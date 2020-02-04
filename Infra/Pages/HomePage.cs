
using AventStack.ExtentReports;
using SeleniumProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace SeleniumProject.Infra.Pages
{
    class HomePage : BasePage
    {
        public enum E_HomePage

        {

            [Description("פנסיה ובריאות")]
            PensionAndWellness,
            [Description("שכר")]
            Payment,
            [Description("תפעול")]
            Operation,
            [Description("Happyness")]
            Happyness,
            [Description("המייל שלי")]
            NyEmail,
            [Description("Help Desk")]
            HelpDesk,
            [Description("MyBiz.פורטל")]
            MyBiz,
            [Description("TIK TAK")]
            TikTak
        }

        public Status QuadroTool(E_HomePage e_HomePage)
        {
            string a = string.Format("//*[contains(@class, 'col-md-full-right')]//span[text() = '{0}']", EnumsHelper.GetDescription(e_HomePage));
            return SeleniumHelper.OnClick(By.XPath(a));
        }


    }
}
