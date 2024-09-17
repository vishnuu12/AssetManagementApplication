using DAL.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL : IRoleDAL
    {

        private readonly IConfiguration _conn;
        private readonly string? _constring;

        public RoleDAL(IConfiguration conn)
        {
            this._conn = conn;
            this._constring = this._conn.GetConnectionString("DefaultConnection");
        }



        public List<RoleModels> GetRoleAll()
        {
            List<RoleModels> roleModels = new List<RoleModels>();
            var sql = @"select RoleId,RoleName,Description,CreatedTime,CreatedBy,ModifiedTime,ModifiedBy from Role;";
            try
            {
                using (var connection = new SqlConnection(_constring))
                {
                    connection.Open();
                    roleModels = connection.Query<RoleModels>(sql).ToList();
                    

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return roleModels;
        }
        public List<RoleModels> GetRoleBy(int id)
        {

            List<RoleModels> roleModels = new List<RoleModels>();
            var sql = @"select RoleId,RoleName,Description,CreatedTime,CreatedBy,ModifiedTime,ModifiedBy from Role where RoleId=@RoleId;";
            try
            {
                using (var connection = new SqlConnection(_constring))
                {
                    roleModels = connection.Query<RoleModels>(sql, new
                    {
                        RoleId = id,
                    }).ToList();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }

            return roleModels;
        }
        public int AddRole(RoleModels roleModels)
        {
            int roleId = 0;
            var sql = @"
Insert into Role
(RoleName,Description,CreatedTime,CreatedBy) 
values (@RoleName,@Description,@CreatedTime,@CreatedBy)";
            try
            {
                using (var connection = new SqlConnection(_constring))
                {
                    roleId = connection.Execute(sql, new
                    {
                        roleModels.RoleName,
                        roleModels.Description,
                        roleModels.CreatedTime,
                        roleModels.CreatedBy,

                    });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return roleId;

        }


        public bool UpdateRole(RoleModels roleModels)
        {
            var isUpdated = false;
            var sql = @"update Role set RoleName = @RoleName,Description = @Description,CreatedTime = @CreatedTime,CreatedBy = @CreatedBy where RoleId = @RoleId";
            try
            {
                using (var connection = new SqlConnection(_constring))
                {

                    var result = connection.Execute(sql, new
                    {
                        roleModels.RoleId,
                        roleModels.RoleName,
                        roleModels.Description,
                        roleModels.CreatedTime,
                        roleModels.CreatedBy,
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



        public bool DeleteRole(int id)
        {
            var isDeleted = false;
            try
            {

                var sql = @"Delete from Role where RoleId=@RoleId";

                using (var connection = new SqlConnection(_constring))
                {
                    if (id > 0)
                    {
                        isDeleted = true;
                    }
                    var result = connection.Execute(sql, new
                    {
                        RoleId = id,
                    });
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
