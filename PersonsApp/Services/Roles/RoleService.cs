using Microsoft.AspNetCore.Identity;
using PersonsApp.Constants;
using PersonsApp.Dtos.Common;
using PersonsApp.Dtos.Roles;
using PersonsApp.Entities;
using PersonsApp.Mappers;

namespace PersonsApp.Services.Roles
{
    public class RoleService : IRoleService
    {
        private readonly RoleManager<RoleEntity> _roleManager;

        public RoleService(
            RoleManager<RoleEntity> roleManager
        )
        {
            this._roleManager = roleManager;
        }
        public Task<ResponseDto<PageDto<List<RoleDto>>>> GetPageAsync(string searchTerm = "", int page = 1, int pageSize = 10)
        {
            throw new NotImplementedException();
        }
        public Task<ResponseDto<RoleDto>> GetOneAsync(string id)
        {
            throw new NotImplementedException();
        }
        public async Task<ResponseDto<RoleActionResponseDto>> CreateAsync(RoleCreateDto dto)
        {
            var roleEntity =RoleMapper.CreateDtoToEntity(dto);
            var result = await _roleManager.CreateAsync(roleEntity);
            if (!result.Succeeded)
            {
                return new ResponseDto<RoleActionResponseDto>
                {
                    StatusCode = HttpStatusCode.BAD_REQUEST,
                    Status = false,
                    Message = string.Join(", ", result.Errors.Select(e => e.Description))
                };
            }
            return new ResponseDto<RoleActionResponseDto>
            {
                StatusCode = HttpStatusCode.CREATED,
                Status = true,
                Message = HttpMessageResponse.REGISTER_CREATED,
                Data = RoleMapper.EntityToActionResponseDto(roleEntity)
            };
        }
        public Task<ResponseDto<RoleActionResponseDto>> EditAsync(string id, RoleEditDto dto)
        {
            throw new NotImplementedException();
        }

        public Task<ResponseDto<RoleActionResponseDto>> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }
        
    }
}