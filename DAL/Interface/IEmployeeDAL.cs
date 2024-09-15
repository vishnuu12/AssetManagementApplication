using Model;

namespace DAL.Interface
{
    public interface IEmployeeDAL
    {
      List<EmployeeModels> GetEmployeeAll(); //declare method here to hide the implementation


        public List<EmployeeModels> GetEmployeeBy(int id);
        int AddEmployee(EmployeeModels employeeModels);

        bool UpdateEmployee(EmployeeModels employeeModels);

        bool DeleteEmployee(int id);

    }
}
