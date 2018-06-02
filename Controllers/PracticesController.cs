using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using hospitalApi.Models;

namespace hospitalApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class PracticesController : ControllerBase
    {
        private readonly HospitalContext _context;

        public PracticesController(HospitalContext context)
        {
            _context = context;
            
        }

        [HttpGet]
        public ActionResult<List<Practices>> GetAll()
        {
            return _context.Practices.ToList();
        }

        [HttpGet("{id}", Name = "GetPractices")]
        public ActionResult<Practices> GetById(long id)
        {
            var item = _context.Practices.Find(id);
            if (item == null)
            {
                return NotFound();
            }
            return item;
        }       
    }
}