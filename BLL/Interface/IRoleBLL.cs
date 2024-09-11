using Model.DtoModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface IRoleBLL
    {
        List<RoleDtoModels> GetRoleAll();
        List<RoleDtoModels> GetRoleBy(int id);

        int AddRole (RoleDtoModels roleDtoModels);
        bool UpdateRole (RoleDtoModels roleDtoModels);
        bool DeleteRole (int id);
    }
}
