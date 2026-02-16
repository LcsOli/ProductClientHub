using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductClientHub.Exceptions.ExceptionsBase;
using ProductsClientHub.Communication.Requests;
using ProductsClientHub.Communication.Responses;
using ProdutClientHub.API.UseCases.Clients.Register;

namespace ProdutClientHub.API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        [HttpPost]
        [ProducesResponseType(typeof(ResponseClientJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ResponseErrorMessagesJson), StatusCodes.Status400BadRequest)]
        
        public IActionResult Register([FromBody]RequestClientJson request)
        {
                var useCase = new RegisterClientUseCase();

                var response = useCase.Execute(request);

                return Created(string.Empty, response);
                     
        }
        [HttpPut]
        public IActionResult Update()
        {
            return Ok("Client updated successfully.");
        }
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok("Retrieved all clients.");
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetbyId([FromRoute]Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Client deleted successfully.");
        }
    }
}
