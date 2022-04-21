using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(x => x.ProductName).NotEmpty();
            RuleFor(x => x.ProductName).MinimumLength(2);
            RuleFor(x => x.UnitPrice).NotEmpty();
            RuleFor(x => x.UnitPrice).GreaterThan(0);
            RuleFor(x => x.UnitPrice).GreaterThanOrEqualTo(10).When(x => x.CategoryId == 1);
            RuleFor(x => x.ProductName).Must(StartWihtA);

        }

        private bool StartWihtA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
