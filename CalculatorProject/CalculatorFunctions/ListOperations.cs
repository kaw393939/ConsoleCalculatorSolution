using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CalculatorProject.CalculatorFunctions
{
    public class ListOperations
    {
        //lists don't automaticly have sum values, the sum method comes from LINQ
        public static Func<List<double>, double> SumList = (a) => a.Sum();

    }
}
