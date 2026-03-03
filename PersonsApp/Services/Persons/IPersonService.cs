using PersonsApp.Dtos.Common;
using PersonsApp.Dtos.Persons;

namespace PersonsApp.Services.Persons
{
    public interface IPersonService
    {
        //solo métodos y funciones, nada de variables, tampoco código con lógica 
        Task<ResponseDto<PersonDto>> GetOneById(Guid id);
    }
}