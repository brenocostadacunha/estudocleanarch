using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact]
        public void CreateProduct_WithValidParameters_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 100, 10, "product image");
            action.Should()
            .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeIdValue_ResultDomainExceptionInvalidId()
        {
            Action action = () => new Product(-1, "Product Name", "Product Description", 100, 10, "product image");
            action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid Id value");
        }

        [Fact]
        public void CreateProduct_ShortNameValue_ResultDomainExceptionShortName()
        {
            Action action = () => new Product(1, "Pr", "Product Description", 100, 10, "product image");
            action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidNameValue_ResultDomainExceptionName()
        {
            Action action = () => new Product(1, " ", "Product Description", 100, 10, "product image");
            action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithNullImageValue_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 100, 10, null);
            action.Should()
            .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_WithEmptyImageValue_ResultObjectValidState()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 100, 10, "");
            action.Should()
            .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_InvalidPriceValue_ResultDomainExceptionPrice()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", -1, 10, "product image");
            action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid price value");
        }

        [Fact]
        public void CreateProduct_WithNullImageName_NoNullReferenceException()
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 100, 10, null);
            action.Should()
            .NotThrow<NullReferenceException>();
        }

        [Theory]
        [InlineData(-5)]
        public void CreateProduct_InvalidStockValue_ResultDomainExceptionStock(int value)
        {
            Action action = () => new Product(1, "Product Name", "Product Description", 100, value, "product image");
            action.Should()
            .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
            .WithMessage("Invalid stock value");
        }
        

    }
}