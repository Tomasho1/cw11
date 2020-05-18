using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Models
{
    public class ClinicDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<PrescriptionMedicament> Prescription_Medicament { get; set; }

        public ClinicDbContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<PrescriptionMedicament>()
           .HasKey(e => new { e.IdMedicament, e.IdPrescription });

            SeedData(modelBuilder);
        }

        public void SeedData(ModelBuilder modelBuilder)
        {
            var doctors = new List<Doctor>();
            doctors.Add(new Doctor
            {
                IdDoctor = 1,
                FirstName = "Maciej",
                LastName = "Kowalski",
                Email = "mkowalski@gmail.com"
            });


            doctors.Add(new Doctor
            {
                IdDoctor = 2,
                FirstName = "Roman",
                LastName = "Polak",
                Email = "romanpolak@gmail.com"
            });

            modelBuilder.Entity<Doctor>().HasData(doctors);

            var patients = new List<Patient>();

            patients.Add(new Patient
            {
                IdPatient = 1,
                FirstName = "Adam",
                LastName = "Wesołowski",
                Birthday = DateTime.Parse("1992-12-21")
            });

            patients.Add(new Patient
            {
                IdPatient = 2,
                FirstName = "Tomasz",
                LastName = "Mazur",
                Birthday = DateTime.Parse("1981-05-11")
            });

            modelBuilder.Entity<Patient>().HasData(patients);

            var medicaments = new List<Medicament>();

            medicaments.Add(new Medicament
            {
                IdMedicament = 1,
                Name = "Rutinoscorbin",
                Description = "Na przeziębienie",
                Type = "Tabletki",
            });

            medicaments.Add(new Medicament
            {
                IdMedicament = 2,
                Name = "Herbapect",
                Description = "Na kaszel",
                Type = "Syrop",
            });

            modelBuilder.Entity<Medicament>().HasData(medicaments);

            var prescriptions = new List<Prescription>();

            prescriptions.Add(new Prescription
            {
                IdPrescription = 1,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddMonths(1),
                IdPatient = 1,
                IdDoctor = 1

            });

            prescriptions.Add(new Prescription
            {
                IdPrescription = 2,
                Date = DateTime.Now,
                DueDate = DateTime.Now.AddMonths(1),
                IdPatient = 2,
                IdDoctor = 2
            });

            modelBuilder.Entity<Prescription>().HasData(prescriptions);

            var prescriptions_medicaments = new List<PrescriptionMedicament>();

            prescriptions_medicaments.Add(new PrescriptionMedicament
            {
                IdPrescription = 1,
                IdMedicament = 1,
                Dose = 2,
                Details = "Brak"
            });

            prescriptions_medicaments.Add(new PrescriptionMedicament
            {
                IdPrescription = 2,
                IdMedicament = 2,
                Details = "Przed posiłkiem"
            });

            modelBuilder.Entity<PrescriptionMedicament>().HasData(prescriptions_medicaments);
        }
    }

}

