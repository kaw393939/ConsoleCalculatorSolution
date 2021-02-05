using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorProject.CalculatorFunctions
{
    public class Operations
    {
        public static Func<double, double, double> Sum = (a, b) => a + b;
        public static Func<double, double, double> Subtraction = (a, b) => a - b;
        public static Func<double, double, double> Multiplication = (a, b) => a * b;
        public static Func<double, double, double> Division = (a, b) => a / b;
        public static Func<double, double, double> Unassigned = (a, b) => 0;

    }
}
