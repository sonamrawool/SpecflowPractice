using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace specflowdemo
{
    [Binding]
    public sealed class Hooks1 : ReusableFunctions
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Before Scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("After Scenario");
            driver.Quit();
        }
    }
}
