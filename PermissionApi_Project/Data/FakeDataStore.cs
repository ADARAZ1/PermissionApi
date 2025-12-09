using PermissionApi.Models;

namespace PermissionApi.Data
{
    public static class FakeDataStore
    {
        public static List<User> Users = new List<User>
        {
            new User { Id = 1, Username = "admin", Email = "admin@test.com", Roles = new List<Role>() },
            new User { Id = 2, Username = "user1", Email = "user1@test.com", Roles = new List<Role>() }
        };

        public static List<Role> Roles = new List<Role>
        {
            new Role { Id = 1, RoleName = "Admin" },
            new Role { Id = 2, RoleName = "User" }
        };
    }
}
