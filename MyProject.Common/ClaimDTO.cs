using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject.Common
{
  public enum policy { allow, deny }

    public class ClaimDTO
    {
        public int Id { get; set; }
        public int RoleId { get; set; }

        public int PermissionId { get; set; }
        public policy Policy { get; set; }
    }
}
