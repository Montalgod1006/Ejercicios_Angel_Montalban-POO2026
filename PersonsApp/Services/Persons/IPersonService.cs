using PersonsApp.Dtos.Common;
using PersonsApp.Dtos.Persons;

namespace PersonsApp.Services.Persons
{
    public interface IPersonService
    {
        //solo métodos y funciones, nada de variables, tampoco código con lógica 
        Task<ResponseDto<PersonDto>> GetOneByIdAsync(string id); //alt mas f2 para renombrar
        Task <ResponseDto<PersonActionResponseDto>> CreateAsync(PersonCreateDto dto);
        Task <ResponseDto<PersonActionResponseDto>> EditAsync(string id, PersonEditDto dto);
        Task<ResponseDto<PersonActionResponseDto>> DeleteAsync (string id);
    }
}