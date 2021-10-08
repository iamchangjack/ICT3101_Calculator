using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using Moq;

namespace ICT3101_Calculator.UnitTests
{
    class AdditionalCalculatorTests
    {

        private Calculator _calculator;
        private Mock<IFileReader> _mockFileReader;

        [SetUp]
        public void Setup()
        {
            _mockFileReader = new Mock<IFileReader>();
            _mockFileReader.Setup(fr =>
            fr.Read("C:\\Users\\Jack\\Source\\repos\\ICT3101_Calculator\\ICT3101_Calculator\\MagicNumbers.txt")).
                Returns(new string[4] { "12", "34", "56", "78" });

            // when told to read a certain textfile, instead apply the following parameters. disregards need to actually access that text file.

            _calculator = new Calculator();
        }

        [Test]
        public void MagicNumber_WhenGivenNumber_ResultEqualsNumber()
        {

            // Act
            double result = _calculator.GenMagicNum(3, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(156));   // when given 3, should return 156. this is based off the '4 values' supplied in the SetUp
        }

        [Test]
        public void MagicNumber_WhenGivenNegativeNumber_ResultEqualsZero()
        {
            // Act
            double result = _calculator.GenMagicNum(-3, _mockFileReader.Object);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
