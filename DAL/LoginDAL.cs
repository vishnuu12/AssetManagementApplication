using DAL.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LoginDAL : ILoginDAL
    {
        private readonly IConfiguration _conn;
        private readonly string? _connstring;

        public LoginDAL(IConfiguration conn)
        {
            this._conn = conn;
            this._connstring = this._conn.GetConnectionString("DefaultConnection");
        }

        public List<LoginModels> GetLoginDetailByUserName(LoginModels models)
        {
            List<LoginModels> loginModels = new List<LoginModels>();
            try
            {
                var sql = @"select LoginId,UserName,EncryptedPassword,CreatedTime,EmployeeId from Login 
where UserName=@UserName";

                using (var conncetion = new SqlConnection(_connstring))
                {
                    conncetion.Open();
                    loginModels = conncetion.Query<LoginModels>(sql, new
                    {
                        models.UserName
                    }).ToList();
                }

            }
            catch(Exception e)
            {

                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return loginModels;
        }

    }
}
