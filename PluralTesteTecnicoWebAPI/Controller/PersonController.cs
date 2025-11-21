using Microsoft.AspNetCore.Mvc;
using PluralTesteTecnicoWebAPI.Service;

namespace PluralTesteTecnicoWebAPI.Controller
{
    [ApiController]
    [Route("/api/person")]
    public class PersonController : ControllerBase
    {
        private readonly PersonService _personService;
        public PersonController(PersonService personService) {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult People([FromQuery] int size, [FromQuery] int page, [FromQuery] string name = null) { 
            return Ok(_personService.GetAll(name, page, size));
        }
    }
}
