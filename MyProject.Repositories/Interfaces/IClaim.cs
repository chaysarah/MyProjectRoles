using System;
using System.Collections.Generic;
using MyProject.Repositories.Entities;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
   public interface IClaim
    {
        List<Claim> GetAll();
        Claim GetById(int id);
        Claim Add(int id, int idRole, int idPermission, policy p);
        Claim Update(Claim Role);
        void Delete(int id);

    }
}
