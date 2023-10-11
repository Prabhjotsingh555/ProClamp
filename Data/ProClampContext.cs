using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProClamp.Models;

namespace ProClamp.Data
{
    public class ProClampContext : DbContext
    {
        //// this representing the database table for Clamp properties.
        public ProClampContext(DbContextOptions<ProClampContext> options)
            : base(options)
        {
        }

        public DbSet<Clamp> Clamp { get; set; } //// this representt the database table for Clamp properties.
    }
}