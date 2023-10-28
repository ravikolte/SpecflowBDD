using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace PageObjectModel_Specflow.StepDefinitions
{
    [Binding]
    public class Table_Custom_Step_Argument_Transformation_StepDefinitions
    {
      
        [Given(@"Fill the data")]
        [Scope(Feature = "Test table specflow")]
        public void GivenFillTheData(Table table)
        {
            var data = table.CreateSet<EmpInfo>();

            foreach (EmpInfo e in data)
            {
                Console.WriteLine(e.Name);
                Console.WriteLine(e.Email);
            }
        }

        [Given(@"print (.*) days from current date")]
        public void GivenPrintDaysFromCurrentDate(int p0)
        {
            var mydate = DateTime.Today.AddDays(p0);
            Console.WriteLine(mydate);
        }




        [Then(@"printt (.* days from current datee)")]
        public void ThenPrinttDaysFromCurrentDatee(DateTime mydate)
        {
            Console.WriteLine(mydate);
        }

        

       
    }
}
