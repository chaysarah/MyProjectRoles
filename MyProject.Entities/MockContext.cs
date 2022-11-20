using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System.Collections.Generic;

namespace MyProject.Mock
{
    public class MockContext : IContext
    {
        public List<Role> Roles { get; set; }
        public List<Permission> Permissions { get; set; }
        public List<Claim> Claims { get; set; }
        public MockContext()
        {
            Roles = new List<Role>();
            Permissions = new List<Permission>();
            Claims = new List<Claim>();
            Roles.Add(new Role { Id = 1, Name = "admin" });
            Permissions.Add(new Permission { Id = 2, Name = "ADAM" });
            Claims.Add(new Claim { Id = 1, RoleId = 25 });
        }
    }
}
