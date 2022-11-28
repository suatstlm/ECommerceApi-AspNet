﻿using FluentValidation;

namespace ETradeApi.Application.Features.OperationClaims.Commands.UpdateOperationClaim
{
    public class UpdateOperationClaimCommandValidator : AbstractValidator<UpdateOperationClaimCommand>
    {
        public UpdateOperationClaimCommandValidator()
        {
            RuleFor(c => c.Name).NotEmpty().MinimumLength(2);
        }
    }
}
