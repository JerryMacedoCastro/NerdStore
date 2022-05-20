using Microsoft.VisualStudio.TestTools.UnitTesting;
using NerdStore.Catalog.Domain;
using NerdStore.Core.DomainObjects;
using System;

namespace NerdStore.Catolog.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Product_Validate_ShouldReturnExceptions()
        {
            // Arrange
            var ex = Assert.ThrowsException<DomainException>(() =>
                new Product(string.Empty, "description", false, 100, Guid.Empty, DateTime.Now, "image", new Dimensions(1, 1, 1))
            );
            Console.WriteLine(ex.Message);
            Assert.AreEqual("O campo nome do produto não pode estar vazio!", ex.Message);
        }
    }
}
