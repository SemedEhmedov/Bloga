using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAppBusiness.DTOs.Category
{
    public class UpdateCategoryDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class UpdateCategoryDtoValidatator : AbstractValidator<UpdateCategoryDto>
    {
        public UpdateCategoryDtoValidatator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .WithMessage("Name duzgun deyil")
                .NotNull()
                .WithMessage("Name duzgun deyil")
                .MinimumLength(3)
                .WithMessage("uzunluq min 3 ola biler");
        }
    }
}
