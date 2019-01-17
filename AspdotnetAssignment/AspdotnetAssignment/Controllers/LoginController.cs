using AspdotnetAssignment.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspdotnetAssignment.Controllers

{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        // POST api/values
        public void Post([FromBody]string email, string password)

        {
            User user = new User();
            user.Username = email;
            user.Password = password;

        }
    }
}