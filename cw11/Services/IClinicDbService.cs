using cw11.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cw11.Services
{
    public interface IClinicDbService
    {
        public Doctor GetDoctors();
        public Doctor AddDoctor();
        public Doctor ModifyDoctor();
        public Doctor DeleteDoctor(int IdDoctor);
    }
}
