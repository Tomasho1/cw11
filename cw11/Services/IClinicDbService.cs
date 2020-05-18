using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IClinicDbService
    {
        public IEnumerable<Doctor> GetDoctors();
        public Doctor AddDoctor(Doctor doctor);
        public Doctor ModifyDoctor(Doctor doctor);
        public Doctor DeleteDoctor(int IdDoctor);
    }
}
