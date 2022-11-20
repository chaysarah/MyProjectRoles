using MyProject.Repositories.Entities;
using MyProject.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Repositories
{
    public class ClaimRepository:IClaim
    {
        private readonly IContext _context;

        public ClaimRepository(IContext c)
        {
            _context = c;
        }

        public Entities.Claim Add(int id, int idRole, int idPermission, policy p)
        {
            Claim r = new Claim() { Id = id, RoleId = idRole, PermissionId = idPermission ,Policy=p};
            _context.Claims.Add(r);
            return r;
        }

        public void Delete(int id)
        {
            Claim r = GetById(id);
            _context.Claims.Remove(r);
        }

        public List<Entities.Claim> GetAll()
        {
            return _context.Claims;
        }

        public Entities.Claim GetById(int id)
        {
            for (int i = 0; i < _context.Claims.Count; i++)
            {
                if (id == _context.Claims[i].Id)
                {
                    return _context.Claims[i];
                }
            }
            return null;
        }

        public Entities.Claim Update(Entities.Claim role)
        {
            Delete(role.Id);
            Add(role.Id, role.RoleId,role.PermissionId,role.Policy);
            return role;
        }
    }
}
