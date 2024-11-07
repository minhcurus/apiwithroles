using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace ApiWithRoles.Controllers
{

    [Authorize(Roles = "Admin")]
    [Route("api/[controller]")]
    public class AdminController : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("You have accessed the Admin controller. ");
        }
    }
}
