using Core.Entity;
using EntityFramework.Connection;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("Api/UserController")]
    public class UserController : Controller
    {
        public static List<User> users = new List<User>();
        [HttpGet]
        public IActionResult GetAll()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddNew(User user)
        {
            var _user = new User
            {
                Id = Guid.NewGuid().ToString(),
                DisplayUserName = user.DisplayUserName,
                UserName = user.UserName,
                Password = user.Password,

            };
            users.Add(_user);
            return View();
        }
    }
}
