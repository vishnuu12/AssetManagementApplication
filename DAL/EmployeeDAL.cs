using DAL.Interface;
using Model;

namespace DAL
{
    public class EmployeeDAL : IEmployeeDAL
    {

        // create a list object to store temp data
        
        public List<EmployeeDtoModel> sample = new List<EmployeeDtoModel>(); 

        /// <summary>
        /// get all the employee details using the below method
        /// </summary>
        /// <returns></returns>
        public List<EmployeeDtoModel> GetAllEmployees()
        {
            sample.Add(new EmployeeDtoModel // adding the sample data to the list 
            {
                EmployeeId = 1,
                Name = "prasanna",
                Email = "Prasn@gmail.com",
                PhoneNumber = "4976826431",
                CreatedBy = "Vishnu",
                CreatedTime = new DateTime()

            });

            sample.Add(new EmployeeDtoModel
            {
                EmployeeId = 2,
                Name = "Rudra priyan",
                Email = "rudra@gmail.com",
                PhoneNumber = "7896124563",
                CreatedBy = "Vivek",
                CreatedTime = new DateTime()
            });

            return sample;
        }
        /// <summary>
        /// Insert the Employee Details to the list (or) db
        /// </summary>
        /// <param name="employeeModels"></param>
        /// <returns></returns>
        public List<EmployeeModels> InsertEmployees()
        {
           return null;
        }
        /// <summary>
        /// Update details for Employeee details
        /// </summary>
        public List<EmployeeModels> UpdateEmployees()
        {
            return UpdateEmployees();
        }

        public List<EmployeeModels> DeleteEmployees()
        {
           return DeleteEmployees();
        }
    }
}
