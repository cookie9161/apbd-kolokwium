// namespace Kolokwium.Data;
//
// public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
// {
//     protected override void OnModelCreating(ModelBuilder modelBuilder)
//     {
//         base.OnModelCreating(modelBuilder);
//         
//         modelBuilder.Entity<PrescriptionMedicament>()
//             .HasKey(pm => new { pm.IdPrescription, pm.IdMedicament });
//
//         modelBuilder.Entity<Prescription>()
//             .HasOne(p => p.Patient)
//             .WithMany(pat => pat.Prescriptions)
//             .HasForeignKey(p => p.IdPatient);
//
//         modelBuilder.Entity<Prescription>()
//             .HasOne(p => p.Doctor)
//             .WithMany(doc => doc.Prescriptions)
//             .HasForeignKey(p => p.IdDoctor);
//         
//         modelBuilder.Entity<Medicament>()
//             .Property(m => m.Type)
//             .HasConversion<string>();
//
//         modelBuilder.Entity<PrescriptionMedicament>()
//             .HasOne(pm => pm.Prescription)
//             .WithMany(p => p.PrescriptionMedicaments)
//             .HasForeignKey(pm => pm.IdPrescription);
//
//         modelBuilder.Entity<PrescriptionMedicament>()
//             .HasOne(pm => pm.Medicament)
//             .WithMany(m => m.PrescriptionMedicaments)
//             .HasForeignKey(pm => pm.IdMedicament);
//     }
// }