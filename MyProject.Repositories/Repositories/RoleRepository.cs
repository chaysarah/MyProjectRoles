using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class RoleRepository : IRole
    {
        private readonly IContext _context;

        public RoleRepository(IContext c)
        {
            _context = c;
        }
        public Role Add(int id, string name)
        {
            Role r = new Role() { Id = id, Name=name};
            _context.Roles.Add(r);
            return r;
        }

        public void Delete(int id)
        {
            Role r = GetById(id);
            _context.Roles.Remove(r);
        }

        public List<Role> GetAll()
        {
            return _context.Roles;
        }

        public Role GetById(int id)
        {
            for (int i = 0; i < _context.Roles.Count; i++)
            {
                if (id== _context.Roles[i].Id)
                {
                    return _context.Roles[i];
                }
            }
            return null;
        }

        public Role Update(Role role)
        {
           Delete(role.Id);
            Add(role.Id,role.Name);
            return role;
        }
    }
}
