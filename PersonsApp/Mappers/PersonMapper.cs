using PersonsApp.Dtos.Persons;
using PersonsApp.Entities;

namespace PersonsApp.Mappers
{
    public static class PersonMapper
    {
        public static PersonEntity CreateDtoToEntity (PersonCreateDto dto)
        {
            return new PersonEntity
            {
                Id =  Guid.NewGuid().ToString(),
                DNI = dto.DNI,
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                BirthDate = dto.BirthDate,
                Gender = dto.Gender,
            };
        }

        public static PersonEntity EditDtoToEntity(PersonEntity entity, PersonEditDto dto)
        {
            entity.FirstName = dto.FirstName;
            entity.LastName = dto.LastName;
            entity.DNI = dto.DNI;
            entity.BirthDate = dto.BirthDate;
            entity.Gender = dto.Gender;

            return entity;
        }
    }
}