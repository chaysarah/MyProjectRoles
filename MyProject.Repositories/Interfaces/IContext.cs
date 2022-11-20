using MyProject.Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Repositories.Interfaces
{
  public interface IContext
    {
        List<Role> Roles { set; get; }
        List<Permission> Permissions { set;get;  }
        List<Claim> Claims { set; get;  }
    }
}
