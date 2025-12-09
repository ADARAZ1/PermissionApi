using Microsoft.AspNetCore.Mvc;
using PermissionApi.Data;
using PermissionApi.Models;

namespace PermissionApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController : ControllerBase
    {
        // GET api/users
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(FakeDataStore.Users);
        }

        // POST api/users
        [HttpPost]
        public IActionResult AddUser([FromBody] User user)
        {
            user.Id = FakeDataStore.Users.Max(u => u.Id) + 1;
            FakeDataStore.Users.Add(user);
            return Ok(user);
        }

        // DELETE api/users/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var user = FakeDataStore.Users.FirstOrDefault(u => u.Id == id);
            if (user == null)
                return NotFound();

            FakeDataStore.Users.Remove(user);
            return Ok();
        }

        // POST api/users/{userId}/roles/{roleId}
        [HttpPost("{userId}/roles/{roleId}")]
        public IActionResult AssignRole(int userId, int roleId)
        {
            var user = FakeDataStore.Users.FirstOrDefault(u => u.Id == userId);
            var role = FakeDataStore.Roles.FirstOrDefault(r => r.Id == roleId);

            if (user == null || role == null)
                return NotFound();

            if (!user.Roles.Any(r => r.Id == roleId))
                user.Roles.Add(role);

            return Ok(user);
        }
    }
}


