using System;
using MyProject.Repositories.Interfaces;
using System.Collections.Generic;
using System.Text;
using MyProject.Repositories.Entities;

namespace MyProject.Repositories.Repositories
{
    public class PermissionRepository : IPermission
    {
        private readonly IContext _context;

        public PermissionRepository(IContext c)
        {
            _context = c;
        }
        public Permission Add(int id, string name)
        {
            Permission r = new Permission() { Id = id, Name = name };
            _context.Permissions.Add(r);
            return r;
        }

        public void Delete(int id)
        {
            Permission r = GetById(id);
            _context.Permissions.Remove(r);
        }

        public List<Permission> GetAll()
        {
            return _context.Permissions;
        }

        public Permission GetById(int id)
        {
            for (int i = 0; i < _context.Permissions.Count; i++)
            {
                if (id == _context.Permissions[i].Id)
                {
                    return _context.Permissions[i];
                }
            }
            return null;
        }

        public Permission Update(Permission role)
        {
            Delete(role.Id);
            Add(role.Id, role.Name);
            return role;
        }
    }
}
