using Microsoft.AspNetCore.Mvc;
using PruebaApiNETCore.Models;
using PruebaApiNETCore.Services;

namespace PruebaApiNETCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private IPeopleService _peopleService;

        public PeopleController([FromKeyedServices("people2Service")] IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }


        [HttpGet]
        public List<People> Get() => Repository.People;


        [HttpGet("{id}")]
        public ActionResult<People> Show(int id) {
            var people = Repository.People.FirstOrDefault(p => p.Id == id);

            if (people == null)
            {
               return NotFound();
            }

            return Ok(people);
        }

        [HttpPost]
        public IActionResult Create(People people)
        {
            if (!_peopleService.Validate(people))
            {
                return BadRequest();
            }

            Repository.People.Add(people);

            return NoContent();
        }
    }

    public class Repository
    {
        public static List<People> People = new List<People>
        {
            new People() {
                Id = 1,
                Name = "John",
                Birthdate = new DateTime(1990, 1, 1),
            },
            new People() {
                Id = 2,
                Name = "Jane",
                Birthdate = new DateTime(1991, 1, 1),
            },
            new People() {
                Id = 3,
                Name = "John",
                Birthdate = new DateTime(1992, 1, 1),
            }
        };
    }
}
