using Model.DtoModels;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interface
{
    public interface IRoleDAL
    {
        List<RoleModels> GetRoleAll();
        List<RoleModels> GetRoleBy(int id);

        int AddRole(RoleModels roleModels);
        bool UpdateRole(RoleModels roleModels);
        bool DeleteRole(int id);
    }
}
