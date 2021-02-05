using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System;
using System.Collections.Generic;

namespace CalculatorProject
{
    public class Calculator
    {

        public List<Calculation> Calculation = new List<Calculation>();


        //Calculator Constructor - A constructor is automaticly called when a class is instantiated

        public Calculator() { }
        public Calculator(double a, double b, string action)
        {

            CreateCalculation(a, b, action);

        }
        public void CreateCalculation(double a, double b, string action)
        {
            Func<double, double, double> _operation;

            switch (action)
            {
                case "sum":
                    _operation = Operations.Sum;
                    break;
                case "difference":
                    _operation = Operations.Subtraction;
                    break;
                case "multiplication":
                    _operation = Operations.Multiplication;
                    break;
                case "division":
                    _operation = Operations.Division;
                    break;
                default:
                    _operation = Operations.Unassigned;
                    break;
            }
            var _calculation = new Calculation(a, b, _operation);

            Calculation.Add(_calculation);

        }
    }
}
