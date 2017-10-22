using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MotoDrive.Dal.DatabaseModel
{
   public class User
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        [ForeignKey("Roles")]
        public string RoleId { get; set; }
        public Roles Roles { get; set; }
    }

    public class Roles
    {
        [Key]
        public int Id { get; set; }
        public string Role { get; set; }
    }

}
