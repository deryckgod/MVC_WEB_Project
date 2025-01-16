using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NorthWindProject_MVC.Models;

namespace NorthWindProject_MVC.Data
{
    public class NorthWindProject_MVCContext : DbContext
    {
        public NorthWindProject_MVCContext (DbContextOptions<NorthWindProject_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<NorthWindProject_MVC.Models.Customers> Customers { get; set; } = default!;
    }
}
