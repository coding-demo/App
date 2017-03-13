using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using App.Interfaces.Business;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Api.Controllers
{
    [Route("api/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IVehicleManagment _manager;
        public VehiclesController(IVehicleManagment manager)
        {
            _manager = manager;
        }

        public IActionResult GetById(int id)
        {
            return Ok(_manager.GetVehicleBy(id));
        }



        [HttpGet("")]
        public IActionResult Get()
        {
            return Ok();
        }

         
        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            //return "Value: " + id.ToString();

            return Ok(_manager.GetVehicleBy(id));
        }
    }
}
