using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{



    [Binding]
    public class UsingCalculatorDivisionsSteps
    {
        //private Calculator _calculator;
        private double result;

        //CalculatorContext serves as replacement for [Given] section
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorDivisionsSteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
        {
            result = _calculator.Divide(p0, p1);
        }
        
        [Then(@"the division result should be ""(.*)""")]
        public void ThenTheDivisionResultShouldBe(Decimal p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }
        
        [Then(@"the division result should be zero")]
        public void ThenTheDivisionResultShouldBeZero()
        {
            Assert.That(result, Is.EqualTo(0));
        }

        [Then(@"the division result should be 1")]
        public void ThenTheDivisionResultShouldBe1()
        {
            Assert.That(result, Is.EqualTo(1));
        }

        [Then(@"the division result should be positive infinity")]
        public void ThenTheDivisionResultShouldBePositiveInfinity()
        {
            Assert.That(result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}
