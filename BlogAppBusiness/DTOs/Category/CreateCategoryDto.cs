using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogAppBusiness.DTOs.Category
{
    public class CreateCategoryDto
    {
        public string Name { get; set; }
    }
    public class CreateCategoryDtoValidatator : AbstractValidator<CreateCategoryDto> 
    {
        public CreateCategoryDtoValidatator()
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
