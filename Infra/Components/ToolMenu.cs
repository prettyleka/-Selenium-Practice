using AventStack.ExtentReports;
using SeleniumProject.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace SeleniumProject.Infra.Components
{
    public class ToolMenu
    {
        #region Enums
        public enum E_Tool
        {

            [Description("דף הבית")]
            HomePage,
            [Description("אודות")]
            Info,
            [Description("כלים ואפליקציות")]
            ToolsAndAppliction,
            [Description("אתרי צוות")]
            TeamPlace,
            [Description("דברים נוספים")]
            AdditionalTools

        }

        public enum E_Info
        {
            [Description("קצת עלינו")] ////*[contains(@class, 'nav')]//li[contains(@rel, '1')]//span[(text() = 'קצת עלינו')]
            About,
            [Description("הנהלה")] ////*[contains(@class, 'nav')]//li[contains(@rel, '1')]//span[(text() = 'הנהלה')]
            Directors,
            [Description("ההיסטוריה שלנו")] ////*[contains(@class, 'nav')]//li[contains(@rel, '1')]//span[(text() = 'ההיסטוריה שלנו')]
            OurHistory,
            [Description("אחריות חברתית")] ////*[contains(@class, 'nav')]//li[contains(@rel, '1')]//span[(text() = 'אחריות חברתית')]
            SocialResponsibility
        }

        public enum E_AppsAndTools
        {
            [Description("TIK TAK")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='TIK TAK')]
            TikTak,
            [Description("אישור שעות")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='TIK TAK')]
            Hours,
            [Description("MyBiz")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='TIK TAK')]
            MyBiz,
            [Description("Help Desk")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='TIK TAK')]
            HelpDesk,
            [Description("WebMail")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='TIK TAK')]
            WebMail,
            [Description("Tas")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='TIK TAK')]
            Tas,
            [Description("Cibus")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='TIK TAK')]
            Cibus,
            [Description("שיחות משוב ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='שיחות משוב')]
            Feedback,
            [Description("CRM Israel")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='CRM Israel')]
            CRMIsrael,
            [Description("לומדה למניעת הטרדה מינית")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='לומדה למניעת הטרדה מינית')]
            SexualHarassment,
            [Description("שינוי סיסמא")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='שינוי סיסמא')]
            PasswordChanging,
            [Description("טופס 101")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='טופס 101')]
            Form101,
            [Description("STARTER")] ////*[contains(@class, 'nav')]//li[contains(@rel, '2')]//a[(text()='STARTER')]
            Starter
        }
        public enum E_AdditionalThings
        {
            [Description("מבוא")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='מבוא')]
            Introduction,
            [Description("מדריך האיכות")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='מדריך האיכות')]
            QualityGuide,
            [Description("נהלי הבטחת איכות")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='נהלי הבטחת איכות')]
            QualityAssuranceProcedures,
            [Description("הוראות עבודה")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='הוראות עבודה')]
            WorkInstructions,
            [Description("תבניות הבטחת איכות")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='תבניות הבטחת איכות')]
            QualityAssuranceTemplates,
            [Description("מצגות הבטחת איכות")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='מצגות הבטחת איכות')] 
            QualityAssurancePresentations,
            [Description("טפסי הבטחת איכות")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='טפסי הבטחת איכות')]
            QualityAssuranceForms,
            [Description("תעודות ISO")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='תעודות ISO')]
            ISO,
            [Description("רשימת הנהלים המלאה ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='רשימת הנהלים המלאה ')]
            ListOfProcedures,
            [Description("נהלי משאבי אנוש ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='נהלי משאבי אנוש')]
            HRProcedures,
            [Description("נהלי תפעול ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='נהלי תפעול')]
            OperatProcedures,
            [Description("נהלי שכר וכספים")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='נהלי שכר וכספים')]
            MoneyAndPayments,
            [Description("נהלי ביטחון")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='נהלי ביטחון')]
            SecurityProcedures,
            [Description("אבטחת מידע")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='אבטחת מידע')]
            DataSecurity,
            [Description("טפסי משאבי אנוש")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='טפסי משאבי אנוש')]
            HRForms,
            [Description("טפסי תפעול ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='טפסי תפעול')]
            OperatingForms,
            [Description("לוח חופשות 2020")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='לוח חופשות 2020')]
            Weekends,
            [Description("מצגת נס הכללית ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='מצגת נס הכללית ' )]
            GeneralPresentation,
            [Description("תקנונים ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='תקנונים ')]
            Policies,
            [Description("הסדרי מסעדות בעתידים ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='הסדרי מסעדות בעתידים')]
            RestaurantArrangements,
            [Description("שרותי שאטל ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='שרותי שאטל ')]
            ShuttleServices,
            [Description("תקנון למניעת הטרדה מינית ")] ////*[contains(@class, 'nav')]//li[contains(@rel, '4')]//span[(text()='תקנון למניעת הטרדה מינית ')]
            SexualHarassmentPreventionPolicy
        }
        #endregion

        #region Methods
        public Status UpperTool(E_Tool e_Tools)
        {

            string b = string.Format("//li[contains(@class,'menu-space') or (@class='mega-menu-item')]//*[text()='{0}']", EnumsHelper.GetDescription(e_Tools));
            return SeleniumHelper.OnClick(By.XPath(b));
        }
        public Status InnerTool(Enum e_Tools)
        {

            string a = string.Format("//li//a[contains(@class,'table_') or (@class='mega_menu_tools_img_link')]//*[text()='{0}']", EnumsHelper.GetDescription(e_Tools));
            return SeleniumHelper.OnClick(By.XPath(a));
        }
        public Status SearchFunction(string Name)
        {
            return SeleniumHelper.InsertText("Valeria", By.XPath("//*[contains(@id, 's2id_autogen1')]"));
        }
        #endregion



    }
}
