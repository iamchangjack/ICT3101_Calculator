using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorDefectDensitySteps
    {
        //private Calculator _calculator;
        private double result;

        //CalculatorContext serves as replacement for [Given] section
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorDefectDensitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Defect Density")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDefectDensity(int p0, int p1)
        {
            result = _calculator.DefectDensity(p0, p1);
        }
        
        [Then(@"the Defect Densitiy should be ""(.*)""")]
        public void ThenTheDefectDensitiyShouldBe(int p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }

    }
}
