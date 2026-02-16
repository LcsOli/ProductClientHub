using System.Net;

namespace ProductClientHub.Exceptions.ExceptionsBase;

public class ErrorOnValidationException : ProductClientHubException
{
    private readonly List<String> _erros;
    public ErrorOnValidationException(List<String> errorMessages) : base(string.Empty)
    {
         _erros = errorMessages;
    }
    
    public override List<string> GetErrors() => _erros;

    public override HttpStatusCode GetHttpStatusCode() => HttpStatusCode.BadRequest;
}