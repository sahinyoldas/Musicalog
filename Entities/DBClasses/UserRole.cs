﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DBClasses
{
    public class UserRole : IBaseEntity
    {
        public long Id { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public long UserId { get; set; }

        [ForeignKey("RoleId")]
        public virtual Role Role { get; set; }

        public long RoleId { get; set; }

    }
}
