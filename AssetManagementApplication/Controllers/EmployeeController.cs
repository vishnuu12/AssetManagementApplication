﻿using BLL.Interface;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace AssetManagementApplication.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeBLL employeeBLL;
        public EmployeeController(IEmployeeBLL employeeBLL)
        {
            this.employeeBLL = employeeBLL;
        }


        [Route("all")]
        [HttpGet]

        public IActionResult GetEmployeeAll()
        {
            var result = employeeBLL.GetEmployeeAll();
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
        public IActionResult GetEmployeeBy(int id)
        {
            var result = employeeBLL.GetEmployeeBy(id);
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
        public int  AddEmployee([FromBody] EmployeeDtoModel employeeDtoModel)
        {
            var response = employeeBLL.AddEmployee(employeeDtoModel);
            return response;
           
        }

        [Route("Update")]
        [HttpPost]
        public bool UpdateEmployee([FromBody] EmployeeDtoModel employeeDtoModel)
        {
           var response = employeeBLL.UpdateEmployee(employeeDtoModel);
            return response;
        }



        [Route("delete/{id}")]
        [HttpDelete]
        public bool DeleteEmployee(int id)
        {
            var response = employeeBLL.DeleteEmployee(id);
            return response;
        }
    }
}
