using Microsoft.AspNetCore.Mvc;
using SQLIte_API_Test.Models;
using SQLIte_API_Test.Repositories.PersonRepository;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SQLIte_API_Test.Controllers
{
    [Route("api/peoples")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;
        private readonly IPersonRepository _personRepository;

        public PersonController(ILogger<PersonController> logger,
                                IPersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }

        [HttpGet("{id}")]
        public IActionResult GetPeopleById(int id)
        {
            try
            {
                var person = _personRepository.GetPeopleById(id);
                return Ok(person);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message);
                return StatusCode(StatusCodes.Status500InternalServerError, new 
                {
                    statusCode = 500,
                    message = ex.Message
                });
            }
        }
    }
}
