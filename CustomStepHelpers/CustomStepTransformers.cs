using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel_Specflow.CustomStepHelpers
{
    [Binding]
    public class CustomStepTransformers
    {
        [StepArgumentTransformation(@"(\d+) days from current datee")]
        public DateTime AddDaysTransformer(int days)
        {
            return DateTime.Today.AddDays(days);
        }
    }
}
