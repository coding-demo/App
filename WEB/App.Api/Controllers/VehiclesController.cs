using Microsoft.AspNetCore.Mvc;

using App.Interfaces.Business;
using System;
using App.DataModels;
using System.Threading.Tasks;



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
                 
                return Created($"/api/v1/vehicles/{resp.Id}", resp);
            }
            catch (Exception ex)
            {

                //log error here using a logger.

                return StatusCode(500);
            }

        }


        [HttpPut("")]
        public IActionResult Put([FromBody] Vehicle data)
        {
            try
            {
                _manager.UpdateVehicle(data);
                return Ok();
            }
            catch (Exception ex)
            {

                //log error here using a logger.

                return StatusCode(500);
            }
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {

            try
            {
                _manager.DeleteVehicleBy(id);
                return NoContent();
            }
            catch (Exception ex)
            {

                //log error here using a logger.

                return StatusCode(500);
            }

        }



    }
}
