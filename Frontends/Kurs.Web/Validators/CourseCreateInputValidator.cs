﻿using FluentValidation;
using Kurs.Web.Models.Catalogs;

namespace Kurs.Web.Validators
{
    public class CourseCreateInputValidator:AbstractValidator<CourseCreateInput>
    {
        public CourseCreateInputValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Isim alani bos olamaz.");
            RuleFor(x => x.Description).NotEmpty().WithMessage("Aciklama alani bos olamaz.");
            RuleFor(x => x.Feature.Duration).InclusiveBetween(1,int.MaxValue).WithMessage("Sure alani bos olamaz.");
            RuleFor(x => x.Price).NotEmpty().WithMessage("Fiyat alani bos olamaz.").ScalePrecision(2,6).WithMessage("Hatali para formati.");// ####.##

        }
    }
}
