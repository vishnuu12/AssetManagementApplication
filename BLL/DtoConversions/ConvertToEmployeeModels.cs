using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DtoConversions
{
    public abstract class ConvertToEmployeeModels
    {
        public List<EmployeeDtoModel> ConvertToEmployeeModel(List<EmployeeModels> employee)
        { 
            List<EmployeeDtoModel> dtoModel = new List<EmployeeDtoModel>();
            {
                foreach(var item in employee)
                {
                    var tempModel = new EmployeeDtoModel();
                    tempModel.EmployeeId = item.EmployeeId;
                    tempModel.Name = item.Name;
                    tempModel.PhoneNo = item.PhoneNo;
                    tempModel.Email = item.Email;
                    tempModel.CreatedTime = item.CreatedTime;
                    tempModel.CreatedBy = item.CreatedBy;
                    tempModel.ModifiedTime = item.ModifiedTime;
                    tempModel.ModifiedBy = item.ModifiedBy;
                    tempModel.RoleId = item.RoleId;
                    dtoModel.Add(tempModel);
                }
                return dtoModel;
            }
        
        }
        public EmployeeModels ConverToEmployeeModel(EmployeeDtoModel employeeDtoModel)
        {
            EmployeeModels employeeModels = new EmployeeModels()
            {
                EmployeeId = employeeDtoModel.EmployeeId,
                Name = employeeDtoModel.Name,
                PhoneNo = employeeDtoModel.PhoneNo,
                Email = employeeDtoModel.Email,
                CreatedTime = employeeDtoModel.CreatedTime,
                CreatedBy = employeeDtoModel.CreatedBy,
                ModifiedTime = employeeDtoModel.ModifiedTime,
                ModifiedBy = employeeDtoModel.ModifiedBy,
                RoleId = employeeDtoModel.RoleId,

            };
            return employeeModels;
        }
    }
}
