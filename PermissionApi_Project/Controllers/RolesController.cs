using Microsoft.AspNetCore.Mvc;
using PermissionApi.Data;
using PermissionApi.Models;

namespace PermissionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolesController : ControllerBase
    {
        // GET api/roles
        [HttpGet]
        public IActionResult GetRoles()
        {
            return Ok(FakeDataStore.Roles);
        }

        // POST api/roles
        [HttpPost]
        public IActionResult AddRole([FromBody] Role role)
        {
            role.Id = FakeDataStore.Roles.Max(r => r.Id) + 1;
            FakeDataStore.Roles.Add(role);

            return Ok(role);
        }
    }
}
