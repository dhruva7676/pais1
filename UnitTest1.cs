using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Threading.Tasks;
using NUnit.Framework;
using Assert = NUnit.Framework.Assert;
using System.Text.RegularExpressions;
using System.Linq;
using System.Threading;

namespace PAIS
{
    [TestFixture]
    public class SRN
    {
        [Test]
        public void SRtoSRN()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Others");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void HOD()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//b[contains(text(),'Service Approval')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_4")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void HOI()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassu2");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//b[contains(text(),'Service Approval')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridView1_BtnEdit_1")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
    
        [Test]
        public void F_Exec()
        {
            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);

            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--start-maximized");
            //driver = new ChromeDriver(options);

            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);


            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("//b[contains(text(),'WO Approval')]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtFinanceSanNum")).SendKeys("54564");
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void F_Dir()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);
           
            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);
            
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("--start-maximized");
            //driver = new ChromeDriver(options);

            //string Url = "http://172.16.18.106/PAIS_Selenium/";
            //IWebDriver driver = new ChromeDriver();
            //driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu4");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t1")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void DDP()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t1")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void PD()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu5");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t4")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewView_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void Dispatch()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t24")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewPO_BtnEdit_6")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDispatch"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonDispatch")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

        [Test]
        public void Head()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fasu6");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();


            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t14")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }
        [Test]
        public void buyer()
        {
            string Url = "http://172.16.18.106/PAIS_Selenium/";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(Url);

            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxEmailId")).SendKeys("fassv3");
            driver.FindElement(By.Id("ContentPlaceHolder1_TextBoxPaswd")).SendKeys("mubop@123");
            driver.FindElement(By.Id("ContentPlaceHolder1_Buttonlogin")).Click();
            Task.Delay(2000).Wait();


            var element = driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t31"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t31")).Click();
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_BUsearch"))).SelectByText("CODMA");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();

            //driver.FindElement(By.Id("ContentPlaceHolder1_TreeView1t14")).Click();
            //Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonSearch")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_GridViewSearch_BtnEditGridViewSearch_0")).Click();
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ButtonAdd")).Click();
            //Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();

            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Btn_Approve")).Click();
            //new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlRequestType"))).SelectByText("Software");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            //Task.Delay(2000).Wait();
            /*driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType"))).SelectByText("indigenous");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlServiceType"))).SelectByText("Individual");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlBudgetSource"))).SelectByText("Institutional Budget");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType")).Click();
            new SelectElement(driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_ddlGrantType"))).SelectByText("Intra Mural Fund");
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_DrpType")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_txtContactNo")).SendKeys("45668799");
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_TxtPIName")).SendKeys("newrequest11");
            Task.Delay(2000).Wait();

            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_add")).Click();
            Task.Delay(2000).Wait();
            var element = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0"));
            var script = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript(script, element);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            Task.Delay(2000).Wait();


            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_itemBtn_0")).Click();
            //Task.Delay(2000).Wait();

            driver.FindElement(By.XPath("/html[1]/body[1]/form[1]/div[4]/div[1]/table[1]/tbody[1]/tr[1]/td[2]/div[1]/div[2]/table[1]/tbody[1]/tr[6]/td[1]/div[1]/table[1]/tbody[1]/tr[5]/td[1]/a[1]")).Click();
            Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_Grid_ItemEntry_Qty_0")).SendKeys("10");
            Task.Delay(2000).Wait();

            var element1 = driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave"));
            var script1 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js1 = (IJavaScriptExecutor)driver;
            js1.ExecuteScript(script1, element1);
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            Task.Delay(2000).Wait();
            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSubmit")).Click();
            Task.Delay(2000).Wait();*/



            driver.SwitchTo().Alert().Accept(); //To Handle Alert Exception
            Task.Delay(2000).Wait();

            var element2 = driver.FindElement(By.Id("HyperLinkLogout"));
            var script2 = "arguments[0].scrollIntoView(true);";
            IJavaScriptExecutor js2 = (IJavaScriptExecutor)driver;
            js2.ExecuteScript(script2, element2);
            //driver.FindElement(By.Id("ContentPlaceHolder1_ContentPlaceHolder3_btnSave")).Click();
            //Task.Delay(2000).Wait();
            driver.FindElement(By.Id("HyperLinkLogout")).Click();
            Task.Delay(2000).Wait();
            driver.Close();
        }

    }
}