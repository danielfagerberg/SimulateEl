using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using SimulateEl.Models;

namespace iniatiative_train.Models
{
    public partial class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<RealConsumption> RealConsumptions { get; set; }



    }
}
