﻿using FluentValidation;

namespace KatlaSport.Services.HiveManagement
{
    /// <summary>
    /// Represents a validator for <see cref="UpdateHiveSectionRequestValidator"/>
    /// </summary>
    public class UpdateHiveSectionRequestValidator : AbstractValidator<UpdateHiveSectionRequest>
    {
        public UpdateHiveSectionRequestValidator()
        {
            RuleFor(r => r.Name).Length(4, 60);
            RuleFor(r => r.Code).Length(5);
            RuleFor(r => r.StoreHiveId).GreaterThan(0);
        }
    }
}