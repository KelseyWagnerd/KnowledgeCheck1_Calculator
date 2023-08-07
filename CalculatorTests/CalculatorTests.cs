using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using KnowledgeCheck1_Calculator;


namespace CalculatorTests
{
       
        [TestClass]
        public class MultiplicationTest
        {
            [TestMethod]
            public void MultiplyIsValid()
            {
                // Arrange
                Calculator calculator = new Calculator();
                var expected = 33;


                // Act
                var actual = calculator.Multiply(11, 3);

                // Assert
                Assert.AreEqual(expected, actual);
            }
        }
    }
