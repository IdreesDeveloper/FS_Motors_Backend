using FS_Motors.Interfaces;
using FS_Motors.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FS_Motors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarInterface _carInterfaceObj;
        public CarsController(ICarInterface carInterfaceObj)
        {
            _carInterfaceObj = carInterfaceObj;
        }
        // GET: api/<CarsController>
        // GET api/<CarsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetSingleUser(int id)
        {
            var result = await _carInterfaceObj.GetSingleCar(id);
            if (result is null)
                return NotFound("Car not found.");

            return Ok(result);
        }

    

        // POST api/<CarsController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
