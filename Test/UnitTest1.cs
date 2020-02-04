using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using SeleniumProject.Infra.Components;
using SeleniumProject.Infra.Pages;
using SeleniumProject.Process;
using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System.Net;

namespace SeleniumProject.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestInitialize]
        public void BeforeTest()
        {
            Reports.GenerateReport.InitReport();
            Reports.GenerateReport.StartTest("TTT");
        }

        [TestMethod]
        public void TTT()
        {
            LogProcess.LoginToNess();
            string URL = SeleniumHelper.GetCurrentURL();
            bool result = URL.Equals("https://homeil.ness.com/israel/Pages/home.aspx");
            Assert.IsTrue(result, String.Format("Expected for '{0}': true; Actual: {1}",
                                     URL, result));

        }
        [TestCleanup]
        public void AfterTest()
        {
            Reports.GenerateReport.EndtestsSuite();
        }

        
    }
   // public void Letstry() => LogProcess.LoginToNess();


}








             /*  [TestMethod]
        public void DownloadAndCheck()
        {

            HomePage HP = new HomePage();
            HP.toolMenu.UpperTool(ToolMenu.E_Tool.AdditionalTools);
            HP.toolMenu.InnerTool(ToolMenu.E_AdditionalThings.HRForms);
            HP.docDownloads.DLoad(DocDownloads.E_DL.Discharge);
            HP.docDownloads.CheckLoad(DocDownloads.E_DL.Discharge);
        }

        [TestMethod]
        public void Upper()
        {
            HomePage HP = new HomePage();
            HP.toolMenu.UpperTool(ToolMenu.E_Tool.Info);
            HP.toolMenu.InnerTool(ToolMenu.E_Info.OurHistory);
            HP.toolMenu.UpperTool(ToolMenu.E_Tool.AdditionalTools);
            HP.toolMenu.InnerTool(ToolMenu.E_AdditionalThings.ISO);

        }

        [TestMethod]
        public void Quadro()
        {
            HomePage HP = new HomePage();
            HP.QuadroTool(HomePage.E_HomePage.Happyness);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
              HP.QuadroTool(HomePage.E_HomePage.HelpDesk);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
              HP.QuadroTool(HomePage.E_HomePage.MyBiz);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
              HP.QuadroTool(HomePage.E_HomePage.NyEmail);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
              HP.QuadroTool(HomePage.E_HomePage.Operation);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
              HP.QuadroTool(HomePage.E_HomePage.Payment);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
              HP.QuadroTool(HomePage.E_HomePage.PensionAndWellness);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
              HP.QuadroTool(HomePage.E_HomePage.TikTak);
              SeleniumHelper.GoToUrl("https://homeil.ness.com/");
        }

        public void StartTesting()
        {
            Reports.GenerateReport.InitReport();
            Reports.GenerateReport.StartTest("EnterToTheSite");
        }


        //Search
        /* HP.toolMenu.SearchFunction("Valeria");
       ;*/


