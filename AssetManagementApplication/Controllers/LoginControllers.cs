using BLL;
using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.Models;

namespace AssetManagementApplication.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class LoginControllers : ControllerBase
    {
        private readonly ILoginBLL _loginBLL;

        public LoginControllers(ILoginBLL loginBLL)
        {
            this._loginBLL = loginBLL;
        }

        [Route("GetLoginDetailsByUserName")]
        [HttpPost]
        public IActionResult GetLoginDetailsByUserName(string Name)
        {
            LoginModels models = new LoginModels();
            models.UserName = Name;
            var result = _loginBLL.GetLoginDetailsByUserName(models);
            var response = new
            {
                status = 200,
                response = result,
                message = "Datas retrived",

            };
            return Ok(response);
        }
    }
}
