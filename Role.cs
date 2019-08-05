using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoleEF
{
    public class Role
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public List<UserRole> UserRole { get; set; }
    }
}
