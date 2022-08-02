using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using TechTalk.SpecFlow;
using TideWebApplication.Utility;

namespace TideWebApplication.CommonMethod
{
    public class CommonMethods
    {
        public void OpenURL()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");
            // two lines

        }

        public void ClickOn()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
        }

        public void SignUpclick()
        {
           
            BaseClass.driver.FindElement(By.XPath("//a[@class='event_internal_link']")).Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            int count = tabs.Count;
            foreach(string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(5000);
        }

        public void SendKeys()
        {

            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//input[@id='name']")).Click();
            BaseClass.driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Danish");
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.Id("email")).Click();
            BaseClass.driver.FindElement(By.Id("email")).SendKeys("hasandanish926@gmail.com");
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.Id("password")).Click();
            BaseClass.driver.FindElement(By.Id("password")).SendKeys("pass@123");
            Thread.Sleep(2000);
        }

        public void Createaccount()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }
        public void OpenURL1()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-u");

        }

        public void ContactUs()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/contact-us'][contains(text(),'Contact Us')]")).Click();
          
        }



        public void Coupons()
        {
            Thread.Sleep(15000);
            BaseClass.driver.FindElement(By.XPath("//input[@class='searchInput']")).Click();
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//input[@class='searchInput']")).SendKeys("Tide coupons");


        }
        public void Verify()  
        {
            //string text=BaseClass.driver.FindElement(By.XPath("//div[@class='articleTitle']")).Text;
            //if(text.Contains("coupons"))
            //{
            //    Console.WriteLine("Text is present");
            //}
            //else
            //{
            //    Console.WriteLine("text is not present");
            //}
            BaseClass.driver.FindElement(By.XPath("//span[@class='fa fa-search']")).Click();
        }

        public void OpenURL3()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");

        }

        public void Livechat()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/live-chat']")).Click();
        }

        public void ChatNow()
        {
            //BaseClass.driver.FindElement(By.XPath("//button[@class='button-link / chat-button event_button_click']")).Click();
            Console.WriteLine("Chat is only opened from 10am to 6pm(UTC)");
        }

        public void Support()
        {
            //BaseClass.driver.FindElement(By.XPath("//button[@class='scroll-to-top-btn event_button_click']")).Click();
            Console.WriteLine("Chat is only opened from 10am to 6pm(UTC)");
        }

        public void OpenURL4()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");

        }

        public void Shopproducts()
        {
        //    Actions actions = new Actions(BaseClass.driver);
        //    var element = BaseClass.driver.FindElement(By.XPath("//span[@itemprop='name'][contains(text(),'Pacs')]"));
        //    actions.MoveToElement(element);
        //    actions.Perform
            Console.WriteLine("This Shopproducts button is not clickable");
        }

        public void Packs()
        {
           
            Thread.Sleep(3000);
            IWebElement Element = BaseClass.driver.FindElement(By.XPath("//span[contains(text(),'Pacs')]"));
            ((IJavaScriptExecutor)BaseClass.driver).ExecuteScript("arguments[0].scrollIntoView();", Element);
            //BaseClass.driver.FindElement(By.XPath("//span[contains(text(),'Pacs')]")).Click();
            ((IJavaScriptExecutor)BaseClass.driver).ExecuteScript("arguments[0].click();", Element);

        }

        public void Findretailers()
        {
            Thread.Sleep(9000);
            BaseClass.driver.FindElement(By.XPath("//*[@class='lilo3746-close-link lilo3746-close-icon']")).Click();
            BaseClass.driver.FindElement(By.XPath("//button[@class='event_button_click']")).Click();
        }

        public void Buy()
        {
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//button[@class='modal-close']")).Click();
        }

        public void OpenURL5()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");

        }

        public void Changelanguage()
        {
            BaseClass.driver.FindElement(By.XPath("//button[contains(text(),'US - English')]")).Click();
        }

        public void Selectlanguage()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://tide.ca']")).Click();
        }

        public void OpenURL6()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-us");

        }

        public void Searchbar()
        {
            Thread.Sleep(9000);
            BaseClass.driver.FindElement(By.XPath("//*[@class='lilo3746-close-link lilo3746-close-icon']")).Click();

            BaseClass.driver.FindElement(By.XPath("//input[@type='search'][@placeholder='Search']")).SendKeys("Tide powder");
            BaseClass.driver.FindElement(By.XPath("//button[@aria-label='Sumbit Search']")).Click();
        }

        public void ClickNews()
        {
            BaseClass.driver.FindElement(By.XPath("//button[@class='active-tab']")).Click();

        }

        public void Readmore()
        {
            Thread.Sleep(3000);
            //BaseClass.driver.FindElement(By.XPath("//a[@class='article-preview-link']")).Click();
        }

        public void OpenURL7()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-u");

        }

        public void Changelanguage1()
        {
            BaseClass.driver.FindElement(By.XPath("//button[contains(text(),'US - English')]")).Click();
        } 

        public void Selectlanguage1()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://tide.com/es-us']")).Click();
        }

        public void OpenURL8()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-u");

        }

        public void Changelanguage2()
        {
            BaseClass.driver.FindElement(By.XPath("//button[contains(text(),'US - English')]")).Click();
        }

        public void Selectlanguage2()
        {
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.XPath("//a[@href='https://tide.ca/fr-ca']")).Click();
        }

        public void OpenURL9()
        {
            BaseClass.driver.Navigate().GoToUrl("https://tide.com/en-u");

        }

        public void ClickOn1()
        {
            BaseClass.driver.FindElement(By.XPath("//a[@href='/en-us/sign-in']")).Click();
        }

        public void SignUpclick1()
        {

            BaseClass.driver.FindElement(By.XPath("//a[@class='event_internal_link']")).Click();
            System.Collections.ObjectModel.ReadOnlyCollection<string> tabs = BaseClass.driver.WindowHandles;
            int count = tabs.Count;
            foreach (string tab in tabs)
            {
                BaseClass.driver.SwitchTo().Window(tab);
            }
            Thread.Sleep(5000);
        }

        public void Login()
        {
            BaseClass.driver.FindElement(By.XPath("//button[@class='underline text-primaryCta lg:text-base leading-light font-montserratSemiBold font-semibold']")).Click();

        }

        public void EnterParticular()
        {
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.Id("login-email")).SendKeys("hasandanish926@gmail.com");
            Thread.Sleep(3000);
            BaseClass.driver.FindElement(By.Id("login-password")).SendKeys("Hsl@7868");
        }

        public void Login1()
        {
            BaseClass.driver.FindElement(By.XPath("//input[@type='submit']")).Click();
        }






        public void scr(string name)
        {
            ((ITakesScreenshot)BaseClass.driver).GetScreenshot().SaveAsFile(@"C:\Users\mindc1may135\source\repos\TideWebApplication\Screenshot" + name + ".png");
        }









    }
}
