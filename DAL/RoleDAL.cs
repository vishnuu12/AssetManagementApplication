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
    public class RoleDAL : IRoleDAL
    {

        private readonly IConfiguration conn;
        private readonly string? constring;

        public RoleDAL(IConfiguration _conn)
        {
            this.conn = _conn;
            this.constring = this.conn.GetConnectionString("DefaultConnection");
        }



        public List<RoleModels> GetRoleAll()
        {
            var sql = @"select RoleId,RoleName,Description,CreatedTime,CreatedBy,ModifiedTime,ModifiedBy from Role;";
            using (var connection = new SqlConnection(constring))
            {
                connection.Open();
                var result = connection.Query<RoleModels>(sql).ToList();
                return result;

            }
        }
        public List<RoleModels> GetRoleBy(int id)
        {
            var sql = @"select RoleId,RoleName,Description,CreatedTime,CreatedBy,ModifiedTime,ModifiedBy from Role where RoleId=@RoleId;";

            using (var connection = new SqlConnection(constring))
            {
                var result = connection.Query<RoleModels>(sql, new
                {
                    RoleId = id,
                }).ToList();
                return result;

            }
        }
        public int AddRole(RoleModels roleModels)
        {
            var sql = @"
Insert into Role
(RoleName,Description,CreatedTime,CreatedBy) 
values (@RoleName,@Description,@CreatedTime,@CreatedBy)";

            using (var connection = new SqlConnection(constring))
            {
                var result = connection.Execute(sql, new
                {
                    roleModels.RoleName,
                    roleModels.Description,
                    roleModels.CreatedTime,
                    roleModels.CreatedBy,
                });
                return result;
            }
        }

        public bool UpdateRole(RoleModels roleModels)
        {
            var isUpdated = false;
            var sql = @"update Role set RoleName = @RoleName,Description = @Description,CreatedTime = @CreatedTime,CreatedBy = @CreatedBy where RoleId = @RoleId";

            using (var connection = new SqlConnection(constring))
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
                return isUpdated;
            }

        }

        public bool DeleteRole(int id)
        {
            var isDeleted = false;

            var sql = @"Delete from Role where RoleId=@RoleId";

            using (var connection = new SqlConnection(constring))
            {
                if (id > 0)
                {
                    isDeleted = true;
                }
                var result = connection.Execute(sql, new
                {
                    RoleId = id,
                });

            
                return isDeleted;
            }
        }
    }
}
