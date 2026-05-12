using PersonsApp.Dtos.Roles;
using PersonsApp.Entities;

namespace PersonsApp.Mappers
{
    public static class RoleMapper
    {
        public static RoleEntity CreateDtoToEntity (RoleCreateDto dto)
        {
            return new RoleEntity
            {
                Id = Guid.NewGuid().ToString(),
                Name = dto.Name,
                Description = dto.Description
            };
        }
        public static RoleActionResponseDto EntityToActionResponseDto(RoleEntity entity)
        {
            return new RoleActionResponseDto
            {
                Id = entity.Id,
                Name = entity.Name
            };
        }
    }
}