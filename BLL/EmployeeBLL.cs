using BLL.Interface;
using DAL.Interface;
using Model;

namespace BLL
{
    public class EmployeeBLL : IEmployeeBLL
    {
        private readonly IEmployeeDAL _employeeDAL; 
        public EmployeeBLL(IEmployeeDAL employeeDAL)
        {
            _employeeDAL = employeeDAL;
        }

        

        public List<EmployeeDtoModel> GetAllEmployees()
        {
            return _employeeDAL.GetAllEmployees();
        }

        public List<EmployeeDtoModel> InsertEmployees()
        {
               return    InsertEmployees();
        }
        public List<EmployeeDtoModel> UpdateEmployees()
        {
            return UpdateEmployees();
        }

        public List<EmployeeDtoModel> DeleteEmployees()
        {
            return DeleteEmployees();
        }
    }
}
