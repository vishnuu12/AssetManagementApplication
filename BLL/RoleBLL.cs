using BLL.DtoConversions;
using BLL.Interface;
using DAL.Interface;
using Model.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RoleBLL : ConvertToRoleDtoModels, IRoleBLL
    {
        private readonly IRoleDAL roleDAL;

        public RoleBLL(IRoleDAL roleDAL)
        {
            this.roleDAL = roleDAL;
        }

        public List<RoleDtoModels> GetRoleAll()
        {
            var role = roleDAL.GetRoleAll();
            var response = this.ConvertToDtoModels(role);
            return response;

        }
        public List<RoleDtoModels> GetRoleBy(int id)
        {
            var role = roleDAL.GetRoleBy(id);
            var response = ConvertToDtoModels(role);
            return response;
        }
        public int AddRole(RoleDtoModels roleDtoModels)
        {
            var role = this.ConvertToRoleModels(roleDtoModels);
            var response = roleDAL.AddRole(role);
            return response;
        }
        public bool UpdateRole(RoleDtoModels roleDtoModels)
        {
            var role = this.ConvertToRoleModels(roleDtoModels);
            var result = roleDAL.UpdateRole(role);
            return result;

        }
        public bool DeleteRole(int id)
        {
            var response = roleDAL.DeleteRole(id);
            return response;
        }
    }
}
