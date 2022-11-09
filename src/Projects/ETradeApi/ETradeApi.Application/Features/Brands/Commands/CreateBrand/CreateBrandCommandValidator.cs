using FluentValidation;

namespace ETradeApi.Application.Features.Brands.Commands.CreateBrand
{
    public class CreateBrandCommandValidator: AbstractValidator<CreateBrandCommand>
    {
        public CreateBrandCommandValidator()
        {
            RuleFor(b => b.Name).NotEmpty();
            RuleFor(b => b.Name).MinimumLength(2);
        }
    }
}
