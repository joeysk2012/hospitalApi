using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using hospitalApi.Models;

namespace hospitalApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly HospitalContext _context;

        public AppointmentsController(HospitalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Appointments>> GetAll()
        {
            return _context.Appointments.ToList();
        }

        [HttpGet("{id}", Name = "GetAppointments")]
        public ActionResult<Appointments> GetById(long id)
        {
            var item = _context.Appointments.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }       
    }
}