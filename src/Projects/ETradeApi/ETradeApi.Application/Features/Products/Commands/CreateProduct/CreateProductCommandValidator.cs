using FluentValidation;

namespace ETradeApi.Application.Features.Products.Commands.CreateProduct
{
    public class CreateProductCommandValidator : AbstractValidator<CreateProductCommand>
    {
        public CreateProductCommandValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                .MaximumLength(150)
                .MinimumLength(2);

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                .Must(s => s >= 0)
                    .WithMessage("Stock information cannot be negative!");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                .Must(s => s >= 0)
                    .WithMessage("Price information cannot be negative!");
        }
    }
}
