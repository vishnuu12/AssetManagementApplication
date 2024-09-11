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
            return 0;
        }
        public bool UpdateRole(RoleDtoModels roleDtoModels)
        {
            return true;
        }
        public bool DeleteRole(int id)
        {
            return true;
        }
    }
}
