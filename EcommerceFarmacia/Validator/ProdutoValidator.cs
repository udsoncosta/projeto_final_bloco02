using EcommerceFarmacia.Model;
using FluentValidation;

namespace EcommerceFarmacia.Validator
{
    public class ProdutoValidator : AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(p => p.Descricao)
                .NotEmpty()
                .MaximumLength(2000);

            RuleFor(p => p.Foto)
                .NotEmpty()
                .MaximumLength(5000);

        }
    }
}