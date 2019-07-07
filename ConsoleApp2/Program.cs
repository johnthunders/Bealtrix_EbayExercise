using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Automation
{
    public class SeleniumExercise
    {
        IWebDriver driver = new ChromeDriver();
        

        private static void Main(string[] args) { }

        [Test]
        public void Ebay()
        {

            driver.Navigate().GoToUrl("https://www.ebay.com/");
            driver.Manage().Window.Maximize();

            driver.FindElement(By.XPath("//input[@id='gh-ac']")).SendKeys("Shoes");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='gh-btn']")).Click();
            Thread.Sleep(1000);

            IJavaScriptExecutor scrolldownShoes = (IJavaScriptExecutor)driver;
            scrolldownShoes.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//span[contains(text(),'PUMA')]")).Click();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//div[@id='srp-river-results-query_answer1']//li[9]")).Click();
            Thread.Sleep(1000);

            string results_shoes = driver.FindElement
                (By.XPath("//div[@class='srp-controls__control srp-controls__count']")).Text;
            Console.WriteLine(results_shoes+" "+"");
            

            Actions orderBy = new Actions(driver);
            orderBy.MoveToElement(driver.FindElement(By.XPath("//div[@id='w4-w3']//div[@class='srp-controls__control--legacy']")))
            .Build().Perform();
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//div[contains(@class,'srp-controls__row-cells right clearfix')]//li[5]//a[1]")).Click();
            

            //First product - Description and price
            string results_shoes_01 = driver.FindElement
                (By.
                CssSelector("body.s-page.no-touch.skin-large.srp--grid-view.no-touch.skin-large.gh-flex:nth-child(2) div.srp-main.srp-main--isLarge:nth-child(8) div.srp-main-content.clearfix.srp-main-content--flex div.srp-river.srp-layout-inner:nth-child(2) div.srp-river-main.clearfix div.srp-river-results.clearfix:nth-child(2) ul.srp-results.srp-grid.clearfix:nth-child(1) li.s-item:nth-child(3) div.s-item__wrapper.clearfix div.s-item__info.clearfix a.s-item__link > h3.s-item__title")).Text;
            string results_shoes_01_price = driver.FindElement
                (By.
                XPath("//span[contains(text(),'S/. 4 937.42')]")).Text;
            Console.WriteLine(results_shoes_01+" "+results_shoes_01_price);
            

            //Second product - Description and price
            string results_shoes_02 = driver.FindElement
                (By.
                CssSelector("body.s-page.no-touch.skin-large.srp--grid-view.no-touch.skin-large.gh-flex:nth-child(2) div.srp-main.srp-main--isLarge:nth-child(8) div.srp-main-content.clearfix.srp-main-content--flex div.srp-river.srp-layout-inner:nth-child(2) div.srp-river-main.clearfix div.srp-river-results.clearfix:nth-child(2) ul.srp-results.srp-grid.clearfix:nth-child(1) li.s-item:nth-child(4) div.s-item__wrapper.clearfix div.s-item__info.clearfix a.s-item__link > h3.s-item__title")).Text;
            string results_shoes_02_price = driver.FindElement
                (By.
                XPath("//span[contains(text(),'S/. 2 633.33')]")).Text;
            Console.WriteLine(results_shoes_02 + " " + results_shoes_02_price);
            

            //Third product - Description and price
            string results_shoes_03 = driver.FindElement
                (By.
                CssSelector("body.s-page.no-touch.skin-large.srp--grid-view.no-touch.skin-large.gh-flex:nth-child(2) div.srp-main.srp-main--isLarge:nth-child(8) div.srp-main-content.clearfix.srp-main-content--flex div.srp-river.srp-layout-inner:nth-child(2) div.srp-river-main.clearfix div.srp-river-results.clearfix:nth-child(2) ul.srp-results.srp-grid.clearfix:nth-child(1) li.s-item:nth-child(5) div.s-item__wrapper.clearfix div.s-item__info.clearfix > a.s-item__link")).Text;
            string results_shoes_03_price = driver.FindElement
                (By.
                XPath("//span[contains(text(),'S/. 2 501.66')]")).Text;
            Console.WriteLine(results_shoes_03 + " " + results_shoes_03_price);
            

            //Fourth product - Description and price
            string results_shoes_04 = driver.FindElement
                (By.
                CssSelector("body.s-page.no-touch.skin-large.srp--grid-view.no-touch.skin-large.gh-flex:nth-child(2) div.srp-main.srp-main--isLarge:nth-child(8) div.srp-main-content.clearfix.srp-main-content--flex div.srp-river.srp-layout-inner:nth-child(2) div.srp-river-main.clearfix div.srp-river-results.clearfix:nth-child(2) ul.srp-results.srp-grid.clearfix:nth-child(1) li.s-item:nth-child(6) div.s-item__wrapper.clearfix div.s-item__info.clearfix a.s-item__link > h3.s-item__title")).Text;
            string results_shoes_04_price = driver.FindElement
                (By.
                XPath("//span[contains(text(),'S/. 2 560.91')]")).Text;
            Console.WriteLine(results_shoes_04 + " " + results_shoes_04_price);
            

            //Fifth product - Description and price
            string results_shoes_05 = driver.FindElement
                (By.
                CssSelector("body.s-page.no-touch.skin-large.srp--grid-view.no-touch.skin-large.gh-flex:nth-child(2) div.srp-main.srp-main--isLarge:nth-child(8) div.srp-main-content.clearfix.srp-main-content--flex div.srp-river.srp-layout-inner:nth-child(2) div.srp-river-main.clearfix div.srp-river-results.clearfix:nth-child(2) ul.srp-results.srp-grid.clearfix:nth-child(1) li.s-item:nth-child(7) div.s-item__wrapper.clearfix div.s-item__info.clearfix a.s-item__link > h3.s-item__title")).Text;
            string results_shoes_05_price = driver.FindElement
                (By.
                XPath("//span[contains(text(),'S/. 2 007.94')]")).Text;
            Console.WriteLine(results_shoes_05 + " " + results_shoes_05_price);

            string[] testArray_desc = new string[] { results_shoes_01, results_shoes_02, results_shoes_03, results_shoes_04, results_shoes_05 };
            Array.Sort(testArray_desc, StringComparer.InvariantCulture);
            Array.ForEach(testArray_desc, x => Console.WriteLine(x));

            string[] testArray_price = new string[] { results_shoes_01_price, results_shoes_02_price, results_shoes_03_price, results_shoes_04_price, results_shoes_05_price };
            Array.Sort(testArray_price, StringComparer.CurrentCulture);
            Array.ForEach(testArray_price, y => Console.WriteLine(y));

        }
        
    }
}