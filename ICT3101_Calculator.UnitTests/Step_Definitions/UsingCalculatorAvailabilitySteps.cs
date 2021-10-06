using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests.Step_Definitions
{
    [Binding]
    public class UsingCalculatorAvailabilitySteps
    {
        //private Calculator _calculator;
        private double result;

        //CalculatorContext serves as replacement for [Given] section
        //Context Injection for SpecFLow:
        private Calculator _calculator;
        public UsingCalculatorAvailabilitySteps(Calculator calc)
        {
            this._calculator = calc;
        }
        //--------------------------------

        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press MTBF")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMTBF(int p0, int p1)
        {
            result = _calculator.MTBF(p0, p1);
        }
        
        [When(@"I have entered ""(.*)"" and ""(.*)"" into the calculator and press Availability")]
        public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(int p0, int p1)
        {
            result = _calculator.Availability(p0, p1);
        }
        
        [Then(@"the MTBF result should be ""(.*)""")]
        public void ThenTheMTBFResultShouldBe(int p0)
        {
            // initially was ThenTheAvailabilityResultShouldBe but conflicts, thus changed
            Assert.That(result, Is.EqualTo(p0));    
        }
        
        [Then(@"the availability result should be ""(.*)""")]
        public void ThenTheAvailabilityResultShouldBe(Decimal p0)
        {
            Assert.That(result, Is.EqualTo(p0));
        }
        
        [Then(@"the availability result should be zero")]
        public void ThenTheAvailabilityResultShouldBeZero()
        {
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
