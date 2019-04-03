using OpenQA.Selenium;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace SeleniumTemplate
{
    [Binding]
    public sealed class Hooks
    {
        public static void Main()
        {
            Console.WriteLine("Starting test...");
            Console.ReadLine();
        }

        public static void WaitIsDisplayed(IWebElement element)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                if(element.Displayed)
                {
                    break;
                }
            }

        }

        [AfterScenario]
        public void AfterScenario()
        {
            StepDefinition.Driver.Close();
        }
    }

}
