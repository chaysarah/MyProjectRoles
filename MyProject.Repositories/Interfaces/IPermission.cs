using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
    public interface IPermission
    {
        List<Permission> GetAll();
        Permission GetById(int id);
        Permission Add(int id, string name);
        Permission Update(Permission Role);
        void Delete(int id);
    }
}
