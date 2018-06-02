using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using hospitalApi.Models;

namespace hospitalApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly HospitalContext _context;

        public PatientsController(HospitalContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<List<Patients>> GetAll()
        {
            return _context.Patients.ToList();
        }

        [HttpGet("{id}", Name = "GetPatients")]
        public ActionResult<Patients> GetById(long id)
        {
            var item = _context.Patients.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }       
    }
}