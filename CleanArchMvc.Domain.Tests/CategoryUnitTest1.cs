using CleanArchMvc.Domain.Entities;
using FluentAssertions;

namespace CleanArchMvc.Domain.Tests;

public class CategoryUnitTest1
{
    [Fact(DisplayName = "Create Category With Valid State")]
    public void CreateCategory_WithValidParameters_ResultObjectValidState()
    {
        Action action = () => new Category(1, "Category Name");
        action.Should()
        .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Category With Negative Id Value")]
    public void CreateCategory_NegativeIdValue_ResultDomainExceptionInvalidId()
    {
        Action action = () => new Category(-1, "Category Name");
        action.Should()
        .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
        .WithMessage("Invalid Id value");
    }

    [Fact(DisplayName = "Create Category With Short Name Value")]
    public void CreateCategory_ShortNameValue_ResultDomainExceptionShortName()
    {
        Action action = () => new Category(1, "Ca");
        action.Should()
        .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }

    [Fact(DisplayName = "Create Category With Null or White Space Name Value")]
    public void CreateCategory_InvalidNameValue_ResultDomainExceptionName()
    {
        Action action = () => new Category(1, " ");
        action.Should()
        .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
    }


}