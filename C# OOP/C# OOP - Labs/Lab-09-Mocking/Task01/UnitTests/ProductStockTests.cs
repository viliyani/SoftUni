using NUnit.Framework;
using System;

namespace INStock.UnitTests
{
    [TestFixture]
    public class ProductStockTests
    {
        private const string ProductLabel = "Test";
        private const string AnotherProductLabel = "Another Test";
        private ProductStock productStock;
        private Product product;
        private Product anotherProduct;

        [SetUp]
        public void SetUpProduct()
        {
            this.product = new Product(ProductLabel, 10, 1);
            this.anotherProduct = new Product(AnotherProductLabel, 10, 20);
            this.productStock = new ProductStock();
        }

        [Test]
        public void AddProductShouldSaveTheProduct()
        {
            // Act
            this.productStock.Add(product);

            // Assert
            var productInStock = this.productStock.FindByLabel(ProductLabel);

            Assert.That(productInStock, Is.Not.Null);
            Assert.That(productInStock.Label, Is.EqualTo(ProductLabel));
            Assert.That(productInStock.Price, Is.EqualTo(10));
            Assert.That(productInStock.Quantity, Is.EqualTo(1));
        }

        [Test]
        public void AddProductShouldThrowExceptionWithDuplicateLabel()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                // Arrange & Act
                this.productStock.Add(this.product);
                this.productStock.Add(this.product);
            }, $"A product with {ProductLabel} label already exists.");
        }

        [Test]
        public void AddingTwoProductsShouldSaveThem()
        {
            // Act
            this.productStock.Add(this.product);
            this.productStock.Add(this.anotherProduct);

            // Assert
            var firstProductInStock = this.productStock.FindByLabel(ProductLabel);
            var secondProductInStock = this.productStock.FindByLabel("Another Test");

            Assert.That(firstProductInStock, Is.Not.Null);
            Assert.That(firstProductInStock.Label, Is.EqualTo(ProductLabel));
            Assert.That(firstProductInStock.Price, Is.EqualTo(10));
            Assert.That(firstProductInStock.Quantity, Is.EqualTo(1));

            Assert.That(secondProductInStock, Is.Not.Null);
            Assert.That(secondProductInStock.Label, Is.EqualTo("Another Test"));
            Assert.That(secondProductInStock.Price, Is.EqualTo(10));
            Assert.That(secondProductInStock.Quantity, Is.EqualTo(20));
        }

        [Test]
        public void ContainsShouldReturnTrueWhenProductExists()
        {
            // Arrange 
            this.productStock.Add(this.product);

            // Act
            var result = this.productStock.Contains(this.product);

            // Assert
            Assert.That(result, Is.True);
        }

        [Test]
        public void ContainsShouldReturnFalseWhenProductExists()
        {
            // Act
            var result = this.productStock.Contains(this.product);

            // Assert
            Assert.That(result, Is.False);
        }

        [Test]
        public void ContainsShouldThrowExceptionWhenProductIsNull()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                // Arrange & Act
                this.productStock.Contains(null);
            }, "Product cannot be null.");
        }

        [Test]
        public void CountShouldReturnCorrectProductCount()
        {
            // Arrange
            this.productStock.Add(this.product);
            this.productStock.Add(this.anotherProduct);

            // Act
            var result = this.productStock.Count;

            // Assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void FindShouldReturnCorrectProductByIndex()
        {
            // Arrange
            this.productStock.Add(this.product);
            this.productStock.Add(this.anotherProduct);

            // Act
            var productInStock = this.productStock.Find(1);

            // Assert
            Assert.That(productInStock, Is.Not.Null);
            Assert.That(productInStock.Label, Is.EqualTo(ProductLabel));
            Assert.That(productInStock.Price, Is.EqualTo(20));
            Assert.That(productInStock.Quantity, Is.EqualTo(10));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-2)]
        public void FindShouldThrowExceptionWhenIndexOutOfRangeOrNegative(int index)
        {
            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                this.productStock.Find(index);
            }, "Product index does not exist.");
        }

        [Test]
        public void RemoveShouldReturnTrueIfExistingProductIsRemoved()
        {
            this.productStock.Add(this.product);
            this.productStock.Add(this.anotherProduct);

            var result = this.productStock.Remove(this.anotherProduct);

            Assert.That(result, Is.True);
            Assert.That(this.productStock.Count, Is.EqualTo(1));
            Assert.That(this.productStock[0].Label, Is.EqualTo(this.product.Label));
        }

        [Test]
        public void RemoveShouldThrowExceptionWhenProductIsNull()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var result = this.productStock.Remove(null);
            }, "The product cannot be null!");
        }

        [Test]
        public void RemoveShouldThrowExceptionIfNoProductsInStock()
        {
            Assert.Throws<InvalidOperationException>(() =>
            {
                var result = this.productStock.Remove(this.anotherProduct);
            }, "There is no products in stock.");
        }

        [Test]
        public void RemoveShouldReturnFalseWhenNoMatchesFound()
        {
            this.productStock.Add(this.product);
            this.productStock.Add(this.anotherProduct);

            var result = this.productStock.Remove(new Product("No Match", 20, 20));

            Assert.That(result, Is.False);
        }


    }
}
