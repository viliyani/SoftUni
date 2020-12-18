using System;
using NUnit.Framework;
using FizzBuzz.Contracts;
using Moq;
using FizzBuzz.Tests.Fakes;

namespace FizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        private IWriter writer;
        private FizzBuzz fizzBuzz;

        [SetUp]
        public void Setup()
        {
            writer = new FakeConsoleWriter();
            fizzBuzz = new FizzBuzz(writer);
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAre1to2ThenResultShouldBeCorrect()
        {
            // Act
            fizzBuzz.PrintNumbers(1, 2);

            // Assert
            Assert.AreEqual("12", ((FakeConsoleWriter)writer).Result);
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAre1to3ThenResultShouldBeCorrect()
        {
            // Act
            fizzBuzz.PrintNumbers(1, 3);

            // Assert
            Assert.AreEqual("12fizz", ((FakeConsoleWriter)writer).Result);
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAre4to6ThenResultShouldBeCorrect()
        {
            // Act
            fizzBuzz.PrintNumbers(4, 6);

            // Assert
            Assert.AreEqual("4buzzfizz", ((FakeConsoleWriter)writer).Result);
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAre14to17ThenResultShouldBeCorrect()
        {
            // Act
            fizzBuzz.PrintNumbers(14, 17);

            // Assert
            Assert.AreEqual("14fizzbuzz1617", ((FakeConsoleWriter)writer).Result);
        }

        [Test]
        public void GivenFizzBuzzWhenNumbersAreMinus5to2ThenResultShouldBeCorrect()
        {
            // Act
            fizzBuzz.PrintNumbers(-5, 2);

            // Assert
            Assert.AreEqual("12", ((FakeConsoleWriter)writer).Result);
        }
    }
}
