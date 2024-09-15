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
        private readonly IConfiguration conn;
        private readonly string? _connstring;

        public EmployeeDAL(IConfiguration conn)
        {
            this.conn = conn;
            this._connstring = this.conn.GetConnectionString("DefaultConnection");
        }



        /// <summary>
        /// get all the employee details using the below method
        /// </summary>
        /// <returns></returns>
        /// 
        // adding the sample data to the list   
        public List<EmployeeModels> GetEmployeeAll()
        {
            var sql = @"select EmployeeId,Name,Email,PhoneNo,CreatedTime,CreatedBy,ModifiedTime,ModifiedBy,RoleId from Employee ";

            using (var connection = new SqlConnection(_connstring))
            {
                connection.Open();
                var result = connection.Query<EmployeeModels>(sql).ToList();
                return result;
            }
        }

        public List<EmployeeModels> GetEmployeeBy(int id)
        {
            var sql = @"select EmployeeId,Name,Email,PhoneNo,CreatedTime,CreatedBy,RoleId from Employee where EmployeeId=@EmployeeId;";

            using (var connection = new SqlConnection(_connstring))
            {
                var result = connection.Query<EmployeeModels>(sql, new
                {
                    EmployeeId = id,
                }).ToList();
                return result;

            }
        }

        public int AddEmployee(EmployeeModels employeeModels)
        {
            var sql = @"Insert into Employee(Name,Email,PhoneNo,CreatedTime,CreatedBy,RoleId) values (@Name,@Email,@PhoneNo,@CreatedTime,@CreatedBy,@RoleId)";
            using (var connection = new SqlConnection(_connstring))
            {
                var result = connection.Execute(sql, new
                {
                    employeeModels.Name,
                    employeeModels.Email,
                    employeeModels.PhoneNo,
                    employeeModels.CreatedTime,
                    employeeModels.CreatedBy,
                    employeeModels.RoleId,

                });
                return result;
            }
        }

        public bool UpdateEmployee(EmployeeModels employeeModels)
        {
            var isUpdated = false;

            var sql = @"update Employee set Name = @Name,Email=@Email,PhoneNo=@PhoneNo,CreatedTime=@CreatedTime,CreatedBy=@CreatedBy,RoleId=@RoleId where EmployeeId=@EmployeeId";

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
            return isUpdated;
        }

        public bool DeleteEmployee(int id)
        {
            var isDeleted = false;

            var sql = @"Delete from Employee where EmployeeId=@EmployeeId";

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
                return isDeleted;
            }

        }
    }
}
