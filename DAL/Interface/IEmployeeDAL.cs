using Model;

namespace DAL.Interface
{
    public interface IEmployeeDAL
    {
      List<EmployeeDtoModel> GetAllEmployees(); //declare method here to hide the implementation

      List<EmployeeModels> InsertEmployees();

      List<EmployeeModels> UpdateEmployees();

      List<EmployeeModels> DeleteEmployees();
       
    }
}
