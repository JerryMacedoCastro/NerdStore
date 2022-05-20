using NerdStore.Core.DomainObjects;
using System;
using Xunit;

namespace NerdStore.Catalog.Domain.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Product_Validate_ShouldReturnExceptions()
        {
            var ex = Assert.Throws<DomainException>(() =>
              new Product(string.Empty, "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensions(1, 1, 1))
          );

            Assert.Equal("O campo Nome do Product n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Nome", string.Empty, false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensions(1, 1, 1))
            );

            Assert.Equal("O campo Descricao do Product n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Nome", "Descricao", false, 0, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensions(1, 1, 1))
            );

            Assert.Equal("O campo Valor do Product n�o pode se menor igual a 0", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Nome", "Descricao", false, 100, Guid.Empty, DateTime.Now, "Imagem", new Dimensions(1, 1, 1))
            );

            Assert.Equal("O campo CategoriaId do Product n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Nome", "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, string.Empty, new Dimensions(1, 1, 1))
            );

            Assert.Equal("O campo Imagem do Product n�o pode estar vazio", ex.Message);

            ex = Assert.Throws<DomainException>(() =>
                new Product("Nome", "Descricao", false, 100, Guid.NewGuid(), DateTime.Now, "Imagem", new Dimensions(0, 1, 1))
            );

            Assert.Equal("O campo Altura n�o pode ser menor ou igual a 0", ex.Message);
        }
    }
}
