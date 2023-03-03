using Medical_Platform.DTO;
using Medical_Platform.Entity.Response;
using Medical_Platform.Manager;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Platform.Controller
{

    [ApiController]
    [Route("api/v1/loginService")]
    public class UserController : ControllerBase
    {
        private UserManager _loginManager;

        public UserController(UserManager loginManager)
        {
            _loginManager = loginManager;
        }
        /* [HttpGet("{id}")]

         public async Task<ActionResult> GetUsers(string id) 
         {

         }
        */

        [HttpPost]
        [Route("login")]
        public async Task<Response> login([FromBody] UserDTO userDto)
        {


            return await _loginManager.Usercheck(userDto);



        }


        [HttpPost]
        [Route("signup")]
        public async Task<Response> signup([FromBody] UserDTO userDto)
        {


            return await _loginManager.CreateUser(userDto);



        }
    }
}

