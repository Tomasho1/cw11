using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
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
        public Doctor AddDoctor()
        {
            throw new NotImplementedException();
        }

        public Doctor DeleteDoctor(int IdDoctor)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Doctor> GetDoctors()
        {
            var res = db.Doctors.ToList();
            return res;
        }

        public Doctor ModifyDoctor()
        {
            throw new NotImplementedException();
        }
    }
}
