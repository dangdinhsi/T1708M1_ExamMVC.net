using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCdotNetCoreT1708M1.Models;

namespace MVCdotNetCoreT1708M1.Models
{
    public class MVCdotNetCoreT1708M1Context : DbContext
    {
        public MVCdotNetCoreT1708M1Context (DbContextOptions<MVCdotNetCoreT1708M1Context> options)
            : base(options)
        {
        }

        public DbSet<MVCdotNetCoreT1708M1.Models.Category> Category { get; set; }

        public DbSet<MVCdotNetCoreT1708M1.Models.Product> Product { get; set; }
    }
}
