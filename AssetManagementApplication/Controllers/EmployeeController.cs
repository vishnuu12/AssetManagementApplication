using BLL.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AssetManagementApplication.Controllers
{

    [ApiController]
    [Route("[controller]")]

    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBLL _employeeBLL;
        public EmployeeController(IEmployeeBLL employeeBLL)
        {
            _employeeBLL = employeeBLL;
        }


        [HttpGet]
        [Route("GetAllEmployees")]
        public IActionResult GetAllEmployees()
        {
            var result = _employeeBLL.GetAllEmployees();


            return Ok(result);
        }

        [HttpPost]
        [Route("InsertEmployees")]
        public IActionResult InsertEmployees()
        {
            //var result = _assetBLL.GetAllEmployees();


            return Ok();
        }

        [HttpPut]
        [Route("UpdateEmployees")]
        public IActionResult UpdateEmployees()
        {
            //var result = _assetBLL.GetAllEmployees();


            return Ok();
        }


            [HttpDelete]
        [Route("DeleteEmployees")]
        public IActionResult DeleteEmployees()
        {
            //var result = _assetBLL.GetAllEmployees();


            return Ok();
        }
    }
}
