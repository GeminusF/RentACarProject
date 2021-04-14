using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator() 
        {
            RuleFor(ci => ci.Id).NotEmpty();
            RuleFor(ci => ci.CarId).NotEmpty();
            RuleFor(ci => ci.ImagePath).NotEmpty();
            RuleFor(ci => ci.Date).NotEmpty();
        }
    }
}
