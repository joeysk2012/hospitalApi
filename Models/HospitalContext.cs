using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace hospitalApi.Models
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        modelBuilder.Entity<Patients>()
            .HasKey(c => c.PatientId);

        modelBuilder.Entity<Practices>()
            .HasKey(c => c.PracticeId);
        
        modelBuilder.Entity<Appointments>()
            .HasKey(c => c.PatientId);    
        }
        

        
        public DbSet<Patients> Patients { get; set; }
        public DbSet<Practices> Practices { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
    }
}