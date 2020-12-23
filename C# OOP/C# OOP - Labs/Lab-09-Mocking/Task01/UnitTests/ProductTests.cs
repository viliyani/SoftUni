using NUnit.Framework;
using System;

namespace INStock.UnitTests
{
    [TestFixture]
    public class ProductTests
    {
        [Test]
        public void LabelCannotBeNull()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Arrange & Act
                var product = new Product(null, 10, 5);

            }, "Label cannot be null or empty.");
        }

        [Test]
        public void LabelCannotBeEmpty()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Arrange & Act
                var product = new Product(string.Empty, 10, 5);

            }, "Label cannot be null or empty.");
        }

        [Test]
        public void PriceCannotBeLessThanZero()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Arrange & Act
                var product = new Product("Test", -10, 5);

            }, "Price cannot be less than zero.");
        }

        [Test]
        public void QuantityCannotBeLessThanZero()
        {
            // Assert
            Assert.Throws<ArgumentException>(() =>
            {
                // Arrange & Act
                var product = new Product("Test Label", 10, -1);

            }, "Quantity cannot be less than zero.");
        }

        [Test]
        public void ProductShouldBeComparedByPriceWhenOrderIsIncorrect()
        {
            // Arrange
            var firstProduct = new Product("Test 1", 10, 1);
            var secondProduct = new Product("Test 2", 5, 1);

            // Act
            var incorrectOrderResult = firstProduct.CompareTo(secondProduct);

            // Assert
            Assert.That(incorrectOrderResult > 0, Is.True);
        }

        [Test]
        public void ProductShouldBeComparedByPriceWhenOrderIsCorrect()
        {
            // Arrange
            var firstProduct = new Product("Test 1", 10, 1);
            var secondProduct = new Product("Test 2", 5, 1);

            // Act
            var correctOrderResult = secondProduct.CompareTo(firstProduct);

            // Assert
            Assert.That(correctOrderResult < 0, Is.True);
        }

        [Test]
        public void ProductShouldBeComparedByPriceWhenOrderIsEqual()
        {
            // Arrange
            var secondProduct = new Product("Test 2", 5, 1);
            var thirdProduct = new Product("Test 3", 5, 1);

            // Act
            var equalOrderResult = secondProduct.CompareTo(thirdProduct);

            // Assert
            Assert.That(equalOrderResult == 0, Is.True);
        }
    }
}
