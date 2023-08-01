using Casgem_Jwt_Example.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Casgem_Jwt_Example.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DefaultController : ControllerBase
    {

        [HttpGet("[Action]")]
        public IActionResult Login()
        {
            return Created(" ", new BuildToken().CreateToken());
        }
        [Authorize]
        [HttpPost("[Action]")]
        public IActionResult CustomerList()
        {
            return Ok("Müşteri Listesine Eriştiniz.");
        }
    }
}
