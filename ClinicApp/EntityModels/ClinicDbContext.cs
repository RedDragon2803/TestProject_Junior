using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace ClinicApp.EntityModels
{
    class ClinicDbContext: DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Properties<DateTime>().Configure(c => c.HasColumnType("datetime2"));
        }
        public DbSet<PatientCard> PatientCardDbSet { get; set; }
        public DbSet<Request> RequestDbSet { get; set; }
    }
}
