using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;
using cw11.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace cw11.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        public IClinicDbService service;

        public DoctorsController(IClinicDbService _service)
        {
            service = _service;
        }

        [HttpGet] 

        public IActionResult GetDoctors()
        {
            var res = service.GetDoctors();
            return Ok(res);
        }

        [HttpDelete]

        public IActionResult DeleteDoctor(int IdDoctor)
        {
            var res = service.DeleteDoctor(IdDoctor);
            return Ok(res);
        }

        [HttpPost]

        public IActionResult AddDoctor (Doctor doctor)
        {
            var res = service.AddDoctor(doctor);
            return Ok(res);
        }

        [HttpPut]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            var res = service.ModifyDoctor(doctor);
            return Ok(res);
        }

    }

}