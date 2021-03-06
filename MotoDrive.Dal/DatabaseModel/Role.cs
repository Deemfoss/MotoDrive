﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MotoDrive.Dal.DatabaseModel
{
    public class Role
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        ICollection<User> Users { get; set; }
    }
}
