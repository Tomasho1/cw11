using cw11.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Threading.Tasks;

namespace cw11.Services
{
    public class EfClinicDbService : IClinicDbService

    {

        private readonly ClinicDbContext db;

        public EfClinicDbService(ClinicDbContext context)
        {
            db = context;
        }
        public Doctor AddDoctor(Doctor doctor)
        {
            var doctorToAdd = new Doctor
            {
                FirstName = doctor.FirstName,
                LastName = doctor.LastName,
                Email = doctor.Email
            };

            db.Doctors.Add(doctorToAdd);
            db.SaveChanges();

            return doctorToAdd;
        }

        public Doctor DeleteDoctor(int IdDoctor)
        {
            var doctorToDelete = db.Doctors.FirstOrDefault(doctor => doctor.IdDoctor == IdDoctor);
            db.Doctors.Remove(doctorToDelete);
            db.SaveChanges();

            return doctorToDelete;
            
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            var res = db.Doctors.ToList();
            return res;
        }

        public Doctor ModifyDoctor(Doctor doctor)
        {
            var doctorToModify = db.Doctors.FirstOrDefault(d => d.IdDoctor == doctor.IdDoctor);
            if (doctorToModify == null)
            {
                throw new Exception("Brak doktora w bazie");
            }

            doctorToModify.FirstName = doctor.FirstName;
            doctorToModify.LastName = doctor.LastName;
            doctorToModify.Email = doctor.Email;

            db.SaveChanges();
            return doctorToModify;

            
        }
    }
}
