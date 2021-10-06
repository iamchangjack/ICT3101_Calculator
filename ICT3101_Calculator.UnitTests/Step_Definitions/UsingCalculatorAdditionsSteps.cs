using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using ICT3101_Calculator;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{

    public class CalculatorContext
    {
        public CalculatorContext()
        {
            calculator = new Calculator();
            //result not instantiated
        }

        public Calculator calculator { get; set; }
        public double result { get; set; }
    }

    [Binding]
    public class UsingCalculatorAdditionsSteps
    {
        /*private Calculator _calculator;
        private double _result;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = CalculatorContext
        }*/

        private readonly CalculatorContext _calculatorContext;

        public UsingCalculatorAdditionsSteps(CalculatorContext _calculatorContext)
        {
            this._calculatorContext = _calculatorContext;
        }


        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _calculatorContext.result = _calculatorContext.calculator.Add(p0, p1);
        }
        [Then(@"the result should be ""(.*)""")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_calculatorContext.result, Is.EqualTo(p0));
        }
    }



}
