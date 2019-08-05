﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UserRoleEF
{
    public class UserRole
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long RoleId { get; set; }
        public User User { get; set; }
        public Role Role { get; set; }
    }
}
