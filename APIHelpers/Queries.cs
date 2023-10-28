using OpenQA.Selenium.DevTools.V116.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel_Specflow.APIHelpers
{
    public class Queries
    {
        public static string getgraphqlquery = "{\r\n  \"query\": \"mutation { insert_todos(objects: {title: \\\"QA RRKK\\\"}) { affected_rows returning { id title user { name } } }}\"\r\n}";

    }
}
