using MyProject.Common;
using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using policy = MyProject.Common.policy;
using System.Text;

namespace MyProject.Services.Interfaces
{
   public interface IClaimServise
    {
        List<ClaimDTO> GetAll();
        ClaimDTO GetById(int id);
        ClaimDTO Add(int id, int idRole, int idPermission, policy p);
        ClaimDTO Update(ClaimDTO Role);
        void Delete(int id);
    }
}
