using DAL.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using Model;
using Model.Models;
using Model.ViewModel;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class EmployeeDAL : IEmployeeDAL
    {
        private readonly IConfiguration _conn;
        private readonly string? _connstring;

        public EmployeeDAL(IConfiguration conn)
        {
            this._conn = conn;
            this._connstring = this._conn.GetConnectionString("DefaultConnection");
        }



        /// <summary>
        /// get all the employee details using the below method
        /// </summary>
        /// <returns></returns>
        /// 
        // adding the sample data to the list   
        public List<EmployeeModels> GetEmployeeAll()
        {
            List<EmployeeModels> employeeModels = new List<EmployeeModels>();
            var sql = @"select EmployeeId,Name,Email,PhoneNo,CreatedTime,CreatedBy,ModifiedTime,ModifiedBy,RoleId from Employee ";

            try
            {
                using (var connection = new SqlConnection(_connstring))
                {
                    connection.Open();
                    employeeModels = connection.Query<EmployeeModels>(sql).ToList();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return employeeModels;
        }

        public List<EmployeeModels> GetEmployeeBy(int id)
        {
            List<EmployeeModels> employeeModels = new List<EmployeeModels>();
            var sql = @"select EmployeeId,Name,Email,PhoneNo,CreatedTime,CreatedBy,RoleId from Employee where EmployeeId=@EmployeeId;";

            try
            {
                using (var connection = new SqlConnection(_connstring))
                {
                    employeeModels = connection.Query<EmployeeModels>(sql, new
                    {
                        EmployeeId = id,
                    }).ToList();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return employeeModels;
        }

        public int AddEmployee(EmployeeModels employeeModels)
        {
            int employeeId = 0;
            var sql = @"Insert into Employee(Name,Email,PhoneNo,CreatedTime,CreatedBy,RoleId) values (@Name,@Email,@PhoneNo,@CreatedTime,@CreatedBy,@RoleId)";
            try
            {
                using (var connection = new SqlConnection(_connstring))
                {
                    employeeId = connection.Execute(sql, new
                    {
                        employeeModels.Name,
                        employeeModels.Email,
                        employeeModels.PhoneNo,
                        employeeModels.CreatedTime,
                        employeeModels.CreatedBy,
                        employeeModels.RoleId,

                    });
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }

            return employeeId;
        }

        public bool UpdateEmployee(EmployeeModels employeeModels)
        {
            var isUpdated = false;

            var sql = @"update Employee set Name = @Name,Email=@Email,PhoneNo=@PhoneNo,CreatedTime=@CreatedTime,CreatedBy=@CreatedBy,RoleId=@RoleId where EmployeeId=@EmployeeId";

            try
            {
                using (var connection = new SqlConnection(_connstring))
                {
                    var result = connection.Execute(sql, new
                    {
                        employeeModels.EmployeeId,
                        employeeModels.Name,
                        employeeModels.Email,
                        employeeModels.PhoneNo,
                        employeeModels.CreatedTime,
                        employeeModels.CreatedBy,
                        employeeModels.RoleId,
                    });

                    if (result > 0)
                    {
                        isUpdated = true;
                    }
                    else
                    {
                        isUpdated = false;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return isUpdated;
        }

        public bool DeleteEmployee(int id)
        {
            var isDeleted = false;

            var sql = @"Delete from Employee where EmployeeId=@EmployeeId";
            try
            {

                using (var connection = new SqlConnection(_connstring))
                {
                    var result = connection.Execute(sql, new
                    {
                        EmployeeId = id,
                    });

                    if (id > 0)
                    {
                        isDeleted = true;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return isDeleted;

        }
    }
}
