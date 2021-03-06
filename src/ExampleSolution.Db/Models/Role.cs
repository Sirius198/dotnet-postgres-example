using System;
using System.Collections.Generic;

namespace ExampleSolution.Db.Models
{
    public partial class Role
    {
        public Role()
        {
            AccountRole = new HashSet<AccountRole>();
        }

        public int RoleId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<AccountRole> AccountRole { get; set; }
    }
}
