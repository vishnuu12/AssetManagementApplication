using Model;

namespace BLL.Interface
{
    public interface IEmployeeBLL
    {
        public List<EmployeeDtoModel> GetAllEmployees(); //declare method here to hide the implementation

        public List<EmployeeDtoModel> InsertEmployees();

        public List<EmployeeDtoModel> UpdateEmployees();

        public List<EmployeeDtoModel> DeleteEmployees();
    }
}
