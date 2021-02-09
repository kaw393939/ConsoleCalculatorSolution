using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorProject;
using System;
using System.Collections.Generic;
using System.Text;
using CalculatorProject.CalculatorFunctions;
using CalculatorProject.Models;
using System.Reflection;
using CalculatorProject.CalculatorFunctions;

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
        public void CalculatorIntantiationWithParametersTest()
        {
            double _a = 1;
            double _b = 2;
            Func<double, double, double> _operations = Operations.Multiplication;

            Calculator _calculator = new Calculator(_a, _b, _operations);
            double _result = _calculator.Calculations[0].GetResult();
            Assert.AreEqual(2, _result);
        }
        [TestMethod()]
        public void CreateCalculationTest()
        {
            double _a = 1;
            double _b = 2;
            Func<double, double, double> _operations = Operations.Multiplication;
            Calculator _calculator = new Calculator();
            _calculator.CreateCalculation(_a, _b, _operations);
            _operations = Operations.Division;
            _calculator.CreateCalculation(_a, _b, _operations);

            
            Assert.AreEqual(2, _calculator.Calculations[0].GetResult());
            Assert.AreEqual(.5, _calculator.Calculations[1].GetResult());

            /*the delegate is run in the foreach
            _calculator.Calculations.ForEach(delegate (Calculation calculation)
            {             
                Assert.AreEqual(2, calculation.GetResult());  
       

            });
            */
        }



    }
}