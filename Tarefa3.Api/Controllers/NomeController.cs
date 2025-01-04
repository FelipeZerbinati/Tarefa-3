using Microsoft.AspNetCore.Mvc;
using Tarefa3.Domain.Interfaces.Service;
using Tarefa3.Domain.Models;
namespace Tarefa3.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NomeController(IPersonService personService) : ControllerBase
    {
        [HttpGet(Name = "GetListPerson")]
        public async Task<IActionResult> GetAll()
        {
            var url = "https://localhost:7025/";
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(url);
            return Ok(personService.GetAll());
        }






    }
}
