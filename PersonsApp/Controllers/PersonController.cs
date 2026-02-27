using Microsoft.AspNetCore.Mvc;
using PersonsApp.Entities;

namespace PersonsApp.Controllers
{
    [Route("api/person")] //Lo que coloquemos aquí tiene que ser // esto es una decoración
    [ApiController] //La instancia es un controlador 
    public class PersonController : ControllerBase //Los dos puntos indica que va a heredar  todos los atributos de ControllerBase
    {
        /*El método se usa cuando se crea un objeto nuevo*/
        private readonly List<PersonEntity> _persons; //El guion bajo se usa para que salgan mas rapido al momento de llamarla
        public PersonController() //ctor método constructor 
        {
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
            [HttpGet("{dni}")]// Se usa Get porque solo voy a hacer una lectura de  // si quiero agregar mas parametros solo pongo pleca
            public IActionResult GetOne(string dni)
            {
                var person = _persons.FirstOrDefault(p => p.DNI == dni);

                return person !=null ? Ok(person) : NotFound(new {Message = "Persona no encontrada."});
            }
            [HttpPost]
            public IActionResult Create(PersonEntity person)
            {
                var personExist = _persons.Any(p => p.DNI == person.DNI);

                if (!personExist)
                {
            _persons.Add(person);
                return Created();
                }
                
                    return BadRequest (new {Message = "El DNI ya esta registrado"});
                
            }
            [HttpPut("{dni}")]
            public IActionResult update(string dni, PersonEntity person)
            {
                var oldPerson = _persons.FirstOrDefault(p => p.DNI == dni);
                if (oldPerson is null)
                {
                    return NotFound(new {Message = "Registro no encontrado."});  
                }
                _persons.Remove(oldPerson);
                _persons.Add(person);
                Console.WriteLine($"Persona actualizada : {person.DNI} - {person.FirstName}  {person.LastName}");

                return Ok(new {Message = "Registro editado correctamente "});   
            }
            [HttpDelete("{dni}")]
            public IActionResult Remove(string dni)
            {
                var Person = _persons.FirstOrDefault(p => p.DNI == dni);
                if (Person is null)
                {
                    return NotFound(new {Message = "Registro no encontrado."});  
                }
                _persons.Remove(Person);
                Console.WriteLine($"Persona eliminada");

                return Ok(new {Message = "Registro eliminado correctamente "});   
            }
    }
}