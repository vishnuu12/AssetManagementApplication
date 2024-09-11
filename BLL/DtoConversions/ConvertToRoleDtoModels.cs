using Model.DtoModels;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DtoConversions
{
    public abstract class ConvertToRoleDtoModels
    {
        public List<RoleDtoModels> ConvertToDtoModels(List<RoleModels> role)
        {
            List<RoleDtoModels> roleDtoModels = new List<RoleDtoModels>();
            foreach(var item in role)
            {
                var roleDtoModel = new RoleDtoModels();
                roleDtoModel.RoleId = item.RoleId;
                roleDtoModel.RoleName = item.RoleName;
                roleDtoModel.Description = item.Description;
                roleDtoModel.CreatedTime = item.CreatedTime;
                roleDtoModel.CreatedBy = item.CreatedBy;
                roleDtoModel.ModifiedTime = item.ModifiedTime;
                roleDtoModel.ModifiedBy = item.ModifiedBy;
                roleDtoModels.Add(roleDtoModel);
            }
            return roleDtoModels;
        }

    }
}
