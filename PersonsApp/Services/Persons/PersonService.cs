using Microsoft.EntityFrameworkCore;
using PersonsApp.Constants;
using PersonsApp.Database;
using PersonsApp.Dtos.Common;
using PersonsApp.Dtos.Persons;
using PersonsApp.Entities;
using PersonsApp.Mappers;

namespace PersonsApp.Services.Persons
{
    public class PersonService : IPersonService
    {
        private readonly PersonsDbContext _context;
        public PersonService(PersonsDbContext context)
        {
            _context = context;
        }
        public async Task<ResponseDto<PersonDto>> GetOneByIdAsync(string id) //Siempre que vamos a devolver un Task se usa un async antes del Task
        {
            var personEntity = await _context.Persons.FirstOrDefaultAsync( 
               p => p.Id == id
            );
             //el Persons es del dbContext y representa la tabla de personas, el first or dfaultAsync es porque estamos usando un task
             if(personEntity is null)
            {
                return new ResponseDto<PersonDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Message = HttpMessageResponse.REGISTER_NOT_FOUND,
                    Status = false,
                };
            }
            return new ResponseDto<PersonDto>
            {
                StatusCode = HttpStatusCode.OK,
                Message = HttpMessageResponse.REGISTER_FOUND,
                Status = true,
                Data = new PersonDto
                {
                    Id = personEntity.Id,
                    DNI = personEntity.DNI,
                    FirstName = personEntity.FirstName,
                    LastName = personEntity.LastName,
                    BirthDate = personEntity.BirthDate,
                    Gender = personEntity.Gender
                }
            };
        }

        public async Task <ResponseDto<PersonActionResponseDto>> CreateAsync(PersonCreateDto dto)  //cuando un metodo es asincrono se pone el Async
        {
            PersonEntity personEntity = PersonMapper.CreateDtoToEntity(dto);

            _context.Persons.Add(personEntity);

            await _context.SaveChangesAsync();

            return new ResponseDto<PersonActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Message = HttpMessageResponse.REGISTER_CREATED,
                Status = true,
                Data = new PersonActionResponseDto
                {
                    Id = personEntity.Id
                }
            };
        }
        public async Task <ResponseDto<PersonActionResponseDto>> EditAsync(string id, PersonEditDto dto)
        {
            var personEntity = await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);

            if (personEntity is null)
            {
                return new ResponseDto<PersonActionResponseDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = HttpMessageResponse.REGISTER_NOT_FOUND
                };
            }

            var personEntityUpdated = PersonMapper.EditDtoToEntity(personEntity, dto);

            _context.Persons.Update(personEntityUpdated);

            await _context.SaveChangesAsync();

            return new ResponseDto<PersonActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = true,
                Message = HttpMessageResponse.REGISTER_UPDATED,
                Data = new PersonActionResponseDto
                {
                    Id = id
                }
            };
        }
        
        public async Task<ResponseDto<PersonActionResponseDto>>DeleteAsync (string id)
        {
             var personEntity = await _context.Persons.FirstOrDefaultAsync(p => p.Id == id);

            if (personEntity is null)
            {
                return new ResponseDto<PersonActionResponseDto>
                {
                    StatusCode = HttpStatusCode.NOT_FOUND,
                    Status = false,
                    Message = HttpMessageResponse.REGISTER_NOT_FOUND
                };
            }

            _context.Persons.Remove(personEntity);
            await _context.SaveChangesAsync();

            return new ResponseDto<PersonActionResponseDto>
            {
                StatusCode = HttpStatusCode.OK,
                Status = true,
                Message = HttpMessageResponse.REGISTER_Deleted,
                Data = new PersonActionResponseDto
                {
                    Id = id
                }
            };
        }
       
    }
}