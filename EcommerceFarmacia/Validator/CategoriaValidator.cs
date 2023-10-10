using FluentValidation;
using EcommerceFarmacia.Model;

namespace EcommerceFarmacia.Validator
{
    public class CategoriaValidator : AbstractValidator<Categoria>
    {
        public CategoriaValidator()
        {
            RuleFor(c => c.Tipo)
                .NotEmpty()
                .MaximumLength(255);

        }
    }
}