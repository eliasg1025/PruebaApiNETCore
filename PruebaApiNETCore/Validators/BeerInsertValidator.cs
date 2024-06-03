using FluentValidation;
using PruebaApiNETCore.DTOs;

namespace PruebaApiNETCore.Validators
{
    public class BeerInsertValidator : AbstractValidator<BeerInsertDto>
    {
        public BeerInsertValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("El nombre es obligatorio");
            RuleFor(x => x.Name).Length(2, 20).WithMessage("La longitud del nombre debe estar entre 2 y 20 caracteres");
        }
    }
}
