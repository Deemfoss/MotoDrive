using Microsoft.EntityFrameworkCore;
using MotoDrive.Dal.DatabaseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace MotoDrive.Dal
{
    public class MotoDriveContext : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }

        public MotoDriveContext(DbContextOptions<MotoDriveContext> options) : base(options) { }

    }
}
