using ICT3101_Calculator;
using NUnit.Framework;

namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        private IFileReader fileReader = new FileReader();

        [SetUp]
        public void Setup()
        {
            // Arrange
            // code change for step 10
            _calculator = new Calculator();
        }
        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }
        [Test]
        public void Subtract_WhenSubtractingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Subtract(3, 2);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void Multiply_WhenMultiplyingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Multiply(2, 2);
            // Assert
            Assert.That(result, Is.EqualTo(4));
        }
        [Test]
        public void Division_WhenDividingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Divide(10, 5);
            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        /*
        [Test]
        [TestCase(0,0)]
        [TestCase(10, 0)]
        [TestCase(0, 10)]
        public void Division_WhenZeroAsInputs_ResultThrowArgumentException(int a, int b)
        {

            // Act and Assert
            Assert.That(() => _calculator.Divide(a, b), Throws.ArgumentException);
        }*/

        [Test]
        public void Factorial_WhenFactorialOneNumber_ResultEqualToFactorial()
        {

            // Act
            int result = _calculator.Factorial(5);
            //Assert
            Assert.That(result, Is.EqualTo(120));       //factorial of 5 - 5*4*3*2*1 - is 120
        }
        [Test]
        public void Factorial_WhenFactorialZero_ResultEqualToOne()
        {

            // Act
            int result = _calculator.Factorial(0);
            //Assert
            Assert.That(result, Is.EqualTo(1));       //factorial of 5 - 5*4*3*2*1 - is 120
        }
        [Test]
        public void Factorial_WhenFactorialNegative_ResultThrowArgumentException()
        {
            // Act and Assert
            Assert.That(() => _calculator.Factorial(-1), Throws.ArgumentException);
        }
        [Test]
        public void Factorial_WhenFactorialDecimal_ResultThrowArgumentException()
        {
            // Act and Assert
            Assert.That(() => _calculator.Factorial(0.357), Throws.ArgumentException);
        }

        //writing tests first
        [Test]
        public void Triangle_WhenGivenHeightLength_ResultEqualToArea()
        {
            //Act

            double result = _calculator.Triangle(10, 5);

            // Assert
            Assert.That(result, Is.EqualTo(25));
        }

        [Test]
        public void Circle_WhenGivenRadius_ResultEqualToArea()
        {
            //Act

            double result = _calculator.Circle(10);

            // Assert

            //assuming that pie is 3.1415. so 10*10*3.1415 = 314.15, rounded to 2 dp

            Assert.That(result, Is.EqualTo(314.15));

            
        }

        //17 and 18

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumentException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }
    }
}