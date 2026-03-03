using Microsoft.EntityFrameworkCore;
using PersonsApp.Constants;
using PersonsApp.Database;
using PersonsApp.Dtos.Common;
using PersonsApp.Dtos.Persons;

namespace PersonsApp.Services.Persons
{
    public class PersonService : IPersonService
    {
        private readonly PersonsDbContext _context;
        public PersonService(PersonsDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseDto<PersonDto>> GetOneById(Guid id)
        {
            var personEntity = await _context.Persons.FirstOrDefaultAsync( 
                p => p.Id == id
            );
             //el Persons es del dbContext y representa la tabla de personas, el first or dfaultAsync es para que no se trabe
             if(personEntity is null)
            {
                return new ResponseDto<PersonDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Message = "Registro no encontrado",
                    Status = false,
                };
            }
        }
    }
}