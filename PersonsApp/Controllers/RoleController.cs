using Microsoft.AspNetCore.Mvc;
using PersonsApp.Dtos.Roles;
using PersonsApp.Services.Roles;

namespace PersonsApp.Controllers
{
    [ApiController]
    [Route("api/role")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(
            IRoleService roleService
        )
        {
            this._roleService = roleService;
        }

        [HttpPost]
            public async Task<ActionResult> Create(RoleCreateDto dto)
            {
                var result = await _roleService.CreateAsync(dto);
                return StatusCode(result.StatusCode, result);
            }
    }
}