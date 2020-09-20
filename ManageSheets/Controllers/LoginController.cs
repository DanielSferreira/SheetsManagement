using System.Threading.Tasks;
using ManageSheets.Models;
using ManageSheets.Services;
using Microsoft.AspNetCore.Mvc;
using Shop.Repositories;

namespace ManageSheets.Controllers
{
    [ApiController]
    [Route("/login")]
    public class LoginController : ControllerBase
    {

        public LoginController()
        {
        }

        public string Get()
        {
            return "Entrando";
        }

        [HttpPost]
        public ActionResult<dynamic> Post([FromBody] User model)
        {
            var user = UserRepo.Get(model.Username, model.Password);

            if (user == null)
                return NotFound(new { message = "Usuário ou senha inválidos" });

            var token = TokenService.GenerateToken(user);
            System.Console.WriteLine(token);
            user.Password = "";

            return new
            {
                user = user,
                token = token
            };
        }
        [HttpGet("out")]
        public string Out()
        {
            return "Saindo";
        }
    }
}
