using Microsoft.AspNetCore.Mvc;

using App.Interfaces.Business;
using System;
using System.Net;
using System.Net.Http;
using App.DataModels;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Api.Controllers
{
    [Route("api/v1/[controller]")]
    public class VehiclesController : Controller
    {
        private readonly IVehicleManagment _manager;
        
        public VehiclesController(IVehicleManagment manager)
        {
            _manager = manager;
        }



        [HttpGet("")]
        public IActionResult Get()
        {
            try
            {
                var resp = _manager.GetAllVehicles();

                return Ok(resp);
            }
            catch(Exception ex)
            {

                //log error here using a logger.

                return StatusCode(500);
                
                    
            }
            
        }

        [HttpGet("{id:int}")]
        public IActionResult Get(int id)
        {
            try
            {
                var resp = _manager.GetVehicleBy(id);

                if (resp==null)
                {
                    return NotFound();
                }
                else
                {
                    return Ok(resp);
                }
                
            }
            catch (Exception ex)
            {

                //log error here using a logger.

                return StatusCode(500);


            }

        }


        [HttpPost("")]
        public async Task<IActionResult> Post([FromBody] Vehicle data)
        {
            try
            {
                var resp = _manager.SaveVehicle(data);

                return Created($"/api/v1/vehicles/{data.Id}", resp);

            }
            catch (Exception ex)
            {

                //log error here using a logger.

                return StatusCode(500);


            }

        }


        [HttpPut]
        public IActionResult Put([FromBody] Vehicle data)
        {

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {

            return Ok(_manager.GetVehicleBy(id));
        }



    }
}
