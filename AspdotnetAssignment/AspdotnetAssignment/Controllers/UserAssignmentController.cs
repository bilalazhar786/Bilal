using Microsoft.AspNetCore.Mvc;

namespace AspdotnetAssignment.Controllers
{
    public class UserAssignmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}