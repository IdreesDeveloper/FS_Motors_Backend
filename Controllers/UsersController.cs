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
        public async Task<ActionResult<List<User>>> GetAllHeroes()
        {
            return await _userInterfaceObj.GetAllUsers();
        }
    }
}
