using Microsoft.AspNetCore.Mvc;

namespace AspdotnetAssignment.Controllers

{
    [Route("api/[controller]")]
    [ApiController]
    public class JoinController : ControllerBase
    {

        public void Post([FromBody]string value)
        {
            Models.User user = new Models.User();
            user.Username = "bilal";
            user.Password = "123456";
            user.Token = "";

        }

    }
}