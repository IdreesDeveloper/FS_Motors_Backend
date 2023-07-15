using FS_Motors.Interfaces;
using FS_Motors.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FS_Motors.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
 //User COntroller
    public class UsersController : ControllerBase
    {
        private readonly IUserInterface _userInterfaceObj;
        public UsersController(IUserInterface userInterfaceObj)
        {
            _userInterfaceObj = userInterfaceObj;
        }
        public async Task<ActionResult<List<User>>> GetAllUseres()
        {
            return await _userInterfaceObj.GetAllUsers();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetSingleUser(int id)
        {
            var result = await _userInterfaceObj.GetSingleUser(id);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpPost]
        public async Task<ActionResult<List<User>>> AddUser(User User)
        {
            var result = await _userInterfaceObj.AddUser(User);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<List<User>>> UpdateUser(int id, User request)
        {
            var result = await _userInterfaceObj.UpdateUser(id, request);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<List<User>>> DeleteUser(int id)
        {
            var result = await _userInterfaceObj.DeleteUser(id);
            if (result is null)
                return NotFound("User not found.");

            return Ok(result);
        }
    }
}
