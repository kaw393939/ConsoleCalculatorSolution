using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System.Reflection;

namespace CalculatorProject.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod()]
        public void CalculatorTest()
        {
            Calculator _calculator = new Calculator();
            Assert.IsInstanceOfType(_calculator, typeof(Calculator));
        }

        [TestMethod()]
        public void SumTest()
        {
            //arrange
            double _a = 1;
            double _b =2;
            double _c;
            
            //act
            _c = Addition.Sum(_a, _b);

            //Assert
            Assert.AreEqual(_c, 3);
        }
        [TestMethod()]
        public void CalculationTest()
        {
            double _a = 1;
            double _b = 2;
            string _action = "multiplication";

            Calculator _calculator = new Calculator(_a, _b, _action);

            var _result = _calculator.Calculation[0].GetResults();
            _action = "division";

            _calculator.CreateCalculation(_a, _b, _action);

            _result = _calculator.Calculation[1].GetResults();
        }



    }
}