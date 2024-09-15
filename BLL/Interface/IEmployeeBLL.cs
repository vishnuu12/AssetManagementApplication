using Model;

namespace BLL.Interface
{
    public interface IEmployeeBLL
    {
        public List<EmployeeDtoModel> GetEmployeeAll(); //declare method here to hide the implementation

        public List<EmployeeDtoModel> GetEmployeeBy(int id);
        int AddEmployee(EmployeeDtoModel employeeDtoModel);

        bool UpdateEmployee(EmployeeDtoModel employeeDtoModel);

        bool DeleteEmployee(int id);
    }
}
