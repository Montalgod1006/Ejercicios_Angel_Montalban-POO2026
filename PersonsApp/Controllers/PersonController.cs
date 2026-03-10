using Microsoft.AspNetCore.Mvc;
using PersonsApp.Dtos.Persons;
using PersonsApp.Entities;
using PersonsApp.Services.Persons;

namespace PersonsApp.Controllers
{
    [Route("api/person")] //Lo que coloquemos aquí tiene que ser // esto es una decoración
    [ApiController] //La instancia es un controlador 
    public class PersonController : ControllerBase //Los dos puntos indica que va a heredar  todos los atributos de ControllerBase
    {
        /*El método se usa cuando se crea un objeto nuevo*/
        private readonly List<PersonEntity> _persons; //El guion bajo se usa para que salgan mas rapido al momento de llamarla
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService) //ctor método constructor 
        {
            _personService = personService;
           // _persons = new List<PersonEntity>();
           /* _persons.Add(new PersonEntity
            {
                DNI  = "0401200012345",
                FirstName = "Juan Carlos",
                LastName = "Perez Hernandez",
                Gender = "M",
                BirthDate = DateTime.Parse("01/06/2000")
            });*/
            _persons = new List<PersonEntity>
            {
                new PersonEntity
                {
                    
                    DNI  = "0401200012345",
                    FirstName = "Juan Carlos",
                    LastName = "Perez Hernandez",
                    Gender = "M",
                    BirthDate = DateTime.Parse("01/06/2000")
                },
                new PersonEntity
                {
                    DNI  = "0401200012346",
                    FirstName = "Mariana Michelle",
                    LastName = "Lopez Pineda",
                    Gender = "F",
                    BirthDate = DateTime.Parse("15/03/2000")
                },
                new PersonEntity
                {
                    DNI  = "0401200012347",
                    FirstName = "Carlos Ismael",
                    LastName = "Rodriguez Mejia",
                    Gender = "M",
                    BirthDate = DateTime.Parse("07/08/1998")
                }
            };
        }
            [HttpGet]
            public IActionResult GetAll()
            {
                return Ok(_persons);
            }
            [HttpGet("{id}")]// Se usa Get porque solo voy a hacer una lectura de  // si quiero agregar mas parametros solo pongo pleca
            public async Task<ActionResult> GetOne(string id)
            {
                var result = await _personService.GetOneByIdAsync(id);
                return StatusCode(result.StatusCode, result);
            }
            [HttpPost]
            public async Task<ActionResult> Create(PersonCreateDto dto)
            {
                var result = await _personService.CreateAsync(dto);
                return StatusCode(result.StatusCode, result);
            }
            [HttpPut("{id}")]
            public async Task <IActionResult> update(string id, PersonEditDto dto)
            {
                 var result = await _personService.EditAsync(id, dto);
                 return StatusCode(result.StatusCode, result);
            }
            [HttpDelete("{id}")]
            public async Task <IActionResult> Delete(string id)
            {
                 var result = await _personService.DeleteAsync(id);
                 return StatusCode(result.StatusCode, result); 
            }
    }
}