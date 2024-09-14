using FluentValidation;
using Kurs.Web.Models.Discounts;

namespace Kurs.Web.Validators
{
    public class DiscountApplyInputValidator : AbstractValidator<DiscountApplyInput>
    {
        public DiscountApplyInputValidator()
        {
            RuleFor(x => x.Code).NotEmpty().WithMessage("Indirim kuponu icin bu alan bos kalamaz.");
        }
    }
}
