using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorFactorialsSteps
    {
        //private Calculator _calculator;
        private double result;

        //CalculatorContext serves as replacement for [Given] section
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorFactorialsSteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------

        [When(@"I have entered ""(.*)"" in the calculator and press factorial")]
        public void WhenIHaveEnteredInTheCalculatorAndPressFactorial(double p0)
        {
            result = _calculator.Factorial(p0);
        }
        
        [Then(@"the factorial result should be ""(.*)""")]
        public void ThenTheFactorialResultShouldBe(int p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }
        
        [Then(@"the factorial result should be one")]
        public void ThenTheFactorialResultShouldBeOne()
        {
            Assert.That(result, Is.EqualTo(1));
        }
    }
}
