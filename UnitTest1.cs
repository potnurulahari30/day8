//importing Nunit framework and our application
using NUnit.Framework;
using Demo_MathLibrary_Testing_using_Nunit;
namespace MathLibrary.Tests
{
    public class CalculatorTests

    {
        private Calculator calculator;
        [SetUp] //attributes
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_ShouldReturnCorrectSum()
        {
            //Assert.Pass();
            int result = calculator.Add(2, 5);
            Assert.That(result, Is.EqualTo(7));
        }
        [Test]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            // Assert.Pass();
            int result = calculator.sub(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }
    }
}