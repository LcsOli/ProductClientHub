using FluentValidation;
using ProductsClientHub.Communication.Requests;

namespace ProdutClientHub.API.UseCases.Clients.Register;

public class RegisterClientValidator : AbstractValidator<RequestClientJson>
{
  public RegisterClientValidator()
  {
      RuleFor(client => client.Name).NotEmpty().WithMessage("Nome não pode ser vazio");
      RuleFor(client => client.Email).EmailAddress().WithMessage("Email invalido!");
  }   
}