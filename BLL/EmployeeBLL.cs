using BLL.DtoConversions;
using BLL.Interface;
using DAL;
using DAL.Interface;
using Model;

namespace BLL
{
    public class EmployeeBLL :ConvertToEmployeeModels, IEmployeeBLL
    {
        private readonly IEmployeeDAL _employeeDAL; 
        public EmployeeBLL(IEmployeeDAL employeeDAL)
        {
            this._employeeDAL = employeeDAL;
        }

        

        public List<EmployeeDtoModel> GetEmployeeAll()
        {
            var employee = _employeeDAL.GetEmployeeAll();
            var response = this.ConvertToEmployeeModel(employee);
            return response;

        }
        public List<EmployeeDtoModel> GetEmployeeBy(int id)
        {
            var employee = _employeeDAL.GetEmployeeBy(id);
            var response = this.ConvertToEmployeeModel(employee);
            return response;

        }

        public int AddEmployee(EmployeeDtoModel employeeDtoModel)
        {
            var employee = this.ConverToEmployeeModel(employeeDtoModel);
            var response = _employeeDAL.AddEmployee(employee);
            return response;
        }
        public bool UpdateEmployee(EmployeeDtoModel employeeDtoModel)
        {
            var employee = this.ConverToEmployeeModel(employeeDtoModel);
            var response = _employeeDAL.UpdateEmployee(employee);
            return response;
        }

        public bool DeleteEmployee(int id)
        {
            var response = _employeeDAL.DeleteEmployee(id);
            return response;
        }
    }
}
