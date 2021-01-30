using Microsoft.EntityFrameworkCore;

namespace LekMed.Database
{
    public class LekMedDbContext : DbContext
    {
        public DbSet<DoctorEntity> Doctors { get; set; }
        public DbSet<PrescriptionEntity> Prescriptions { get; set; }
        public DbSet<MedicineEntity> Medicines { get; set; }

        public LekMedDbContext(DbContextOptions options): base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DoctorEntity>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.HasMany(p => p.Prescriptions).WithOne(d => d.Doctor).HasForeignKey(k => k.DoctorId);
            });

            modelBuilder.Entity<PrescriptionEntity>(entity =>
            {
                entity.HasKey(k => k.Id);
                entity.HasMany(m => m.Medicines).WithOne(p => p.Prescription).HasForeignKey(k => k.PrescriptionId);
            });

            modelBuilder.Entity<MedicineEntity>(entity =>
            {
                entity.HasKey(k => k.Id);
            });
        }
    }
}
