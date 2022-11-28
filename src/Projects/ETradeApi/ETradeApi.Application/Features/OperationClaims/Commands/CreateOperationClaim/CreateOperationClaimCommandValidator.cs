﻿using FluentValidation;

namespace ETradeApi.Application.Features.OperationClaims.Commands.CreateOperationClaim
{
    public class CreateOperationClaimCommandValidator : AbstractValidator<CreateOperationClaimCommand>
    {
        public CreateOperationClaimCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
        }
    }
}
