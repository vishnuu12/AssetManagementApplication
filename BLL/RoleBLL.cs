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
        private readonly IRoleDAL _roleDAL;

        public RoleBLL(IRoleDAL roleDAL)
        {
            this._roleDAL = roleDAL;
        }

        public List<RoleDtoModels> GetRoleAll()
        {
            var role = _roleDAL.GetRoleAll();
            var response = this.ConvertToDtoModels(role);
            return response;

        }
        public List<RoleDtoModels> GetRoleBy(int id)
        {
            var role = _roleDAL.GetRoleBy(id);
            var response = ConvertToDtoModels(role);
            return response;
        }
        public int AddRole(RoleDtoModels roleDtoModels)
        {
            var role = this.ConvertToRoleModels(roleDtoModels);
            var response = _roleDAL.AddRole(role);
            return response;
        }
        public bool UpdateRole(RoleDtoModels roleDtoModels)
        {
            var role = this.ConvertToRoleModels(roleDtoModels);
            var result = _roleDAL.UpdateRole(role);
            return result;

        }
        public bool DeleteRole(int id)
        {
            var response = _roleDAL.DeleteRole(id);
            return response;
        }
    }
}
