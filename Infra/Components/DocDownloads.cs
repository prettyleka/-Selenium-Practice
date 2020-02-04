using AventStack.ExtentReports;
using System.Collections.Generic;
using OpenQA.Selenium;
using SeleniumProject;
using SeleniumProject.Configuration;
using SeleniumProject.Helpers;
//using OpenQA.Selenium;
using System;
using System.ComponentModel;
using SeleniumProject.Infra.Pages;
using System.IO;

namespace SeleniumProject.Infra.Components
{
    public class DocDownloads
    {
        #region Enums
        public enum E_DL
        {

            [Description("טופס בקשת חופשה ללא תשלום")]
            OffDayWithoutPayment,
            [Description("טופס התפטרות מהעבודה")]
            Discharge,
            [Description("טופס בקשה להכשרה מקצועית")]
            Study,
            [Description("טופס חזרת עובד מחופשה ללא תשלום")]
            BackFromOffDayWithoutPayment,
            [Description("לימודים על חשבון החברה כתב התחייבות")]
            StudyCompanyPay,
            [Description("טופס עדכון שינוי דיווחי שעות - נס ישראל")]
            ChangeHoursReport

        }

        #endregion

        #region Methods
        public Status DLoad(E_DL e_DL)
        {
            string a = string.Format("//td[contains(@role, 'gridcell')]//a[text()='{0}']", EnumsHelper.GetDescription(e_DL));
            return SeleniumHelper.OnClick(By.XPath(a));
        }

        public void CheckLoad(E_DL e_DL)
        {
            string texter = string.Format("//td[contains(@role, 'gridcell')]//a[text()='{0}']", EnumsHelper.GetDescription(e_DL));
            string name = SeleniumHelper.GetTextFromElement(By.XPath(texter));
            string filePath = @"C:\Users\Shushu HaShual\Downloads\" +"/" + name +".doc";
            Console.WriteLine(File.Exists(filePath) ? Status.Pass : Status.Error);
        }


        
        #endregion
    }
}
