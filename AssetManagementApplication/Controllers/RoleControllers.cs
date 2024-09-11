
using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.DtoModels;

namespace AssetManagementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleControllers : ControllerBase
    {
        private readonly IRoleBLL iRoleBLL;
        public RoleControllers(IRoleBLL iRoleBLL)
        {
            this.iRoleBLL = iRoleBLL;
        }
        [Route("all")]
        [HttpGet]
        public IActionResult GetRoleAll()
        {
            var result = iRoleBLL.GetRoleAll();
            var response = new
            {
                status = 200,
                response = result,
                message = "Datas retrived",

            };
            return Ok(response);
        }
        [Route("{id}")]
        [HttpGet]

        public IActionResult GetRoleBy(int id)
        {
            var result = iRoleBLL.GetRoleBy(id);
            var response = new
            {
                status = 200,
                response = result,
                message = "Datas retrived",

            };
            return Ok(response);

        }
        [Route("Add")]
        [HttpPost]

        public int AddRole(RoleDtoModels roleDtoModels)
        {
            var response = iRoleBLL.AddRole(roleDtoModels);
            return response;
        }

        [Route("Update")]
        [HttpPost]

        public bool UpdateRole(RoleDtoModels roleDtoModels)
        {
            var response = iRoleBLL.UpdateRole(roleDtoModels);
            return response;
        }
        [Route("Delete/{id}")]
        [HttpDelete]
        public bool DeleteRole(int id)
        {
            var response = iRoleBLL.DeleteRole(id);
            return response;
        }
    }
}
