using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
   public interface IRole
    {
        List<Role> GetAll();
        Role GetById(int id);
        Role Add(int id, string name);
        Role Update(Role Role);
        void Delete(int id);
    }
}
