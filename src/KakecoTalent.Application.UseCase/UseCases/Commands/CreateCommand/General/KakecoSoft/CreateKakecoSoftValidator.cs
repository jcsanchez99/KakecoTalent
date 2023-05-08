using FluentValidation;

namespace KakecoTalent.Application.UseCase.UseCases.Commands.CreateCommand.General.KakecoSoft
{
    public class CreateKakecoSoftValidator : AbstractValidator<CreateKakecoSoftCommand>
    {
        public CreateKakecoSoftValidator()
        {
            RuleFor(x => x.Codigo)
                .NotNull().WithMessage("El Código no puede ser nulo.")
                .NotEmpty().WithMessage("El Código no puede ser vacio.");
            RuleFor(x => x.Nombre)
                .NotNull().WithMessage("El Nombre no puede ser nulo.")
                .NotEmpty().WithMessage("El Nombre no puede ser vacio.");
            RuleFor(x => x.Direccion)
                .NotNull().WithMessage("La Dirección no puede ser nulo.")
                .NotEmpty().WithMessage("La Dirección no puede ser vacio.");
            RuleFor(x => x.Telefono)
               .NotNull().WithMessage("El Teléfono no puede ser nulo.")
               .NotEmpty().Length(9, 10).WithMessage("El Teléfono debe tener una longitud entre 9 y 10 numeros.");
            RuleFor(x => x.Email)
               .NotNull().NotEmpty().WithMessage("El Email no puede ser vacio.")
               .EmailAddress().WithMessage("El Email no es válido.");
        }
    }
}
