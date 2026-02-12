using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProductClientHub.Exceptions.ExceptionsBase;
using ProductsClientHub.Communication.Responses;

namespace ProdutClientHub.API.Filters;

    public class ExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context) 
        { 
            if(context.Exception is ProductClientHubException)
            {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Result = new ObjectResult(new ResponseErrorMessagesJson("Erro desconhecido"));
        }
            else
            {

            }
        }
    
    
    private void ThrowUnknowError(ExceptionContext context)
        {
            context.HttpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
        context.Result = new ObjectResult(new ResponseErrorMessagesJson("Erro desconhecido"));
        }
}
