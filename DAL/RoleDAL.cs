using DAL.Interface;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoleDAL : IRoleDAL
    {
        public List<RoleModels> GetRoleAll()
        {
            List<RoleModels> roleModels = new List<RoleModels>();
            RoleModels rolemodel1 = new RoleModels() { RoleId = 1, RoleName = "Vinith", Description = "aaa", CreatedTime = DateTime.Now, CreatedBy = "vivi", ModifiedTime = DateTime.Now, ModifiedBy = "bbb" };
            RoleModels rolemodel2 = new RoleModels() { RoleId = 2, RoleName = "Theri", Description = "Jilla", CreatedTime = DateTime.Now, CreatedBy = "Nayak", ModifiedTime = DateTime.Now, ModifiedBy = "ccc" };
            roleModels.Add(rolemodel1);
            roleModels.Add(rolemodel2);
            return roleModels;

        }
        public List<RoleModels> GetRoleBy(int id)
        {
            List<RoleModels> roleModels = new List<RoleModels>();
            RoleModels rolemodel1 = new RoleModels() { RoleId = 1, RoleName = "Vinith", Description = "aaa", CreatedTime = DateTime.Now, CreatedBy = "vivi", ModifiedTime = DateTime.Now, ModifiedBy = "bbb" };
            RoleModels rolemodel2 = new RoleModels() { RoleId = 2, RoleName = "Theri", Description = "Jilla", CreatedTime = DateTime.Now, CreatedBy = "Nayak", ModifiedTime = DateTime.Now, ModifiedBy = "ccc" };
            roleModels.Add(rolemodel1);
            roleModels.Add(rolemodel2);
            return roleModels.Where(x => x.RoleId == id).ToList();
        }
        public int AddRole()
        {
            return 0;
        }

        public bool UpdateRole()
        {
            return true;
        }

        public bool DeleteRole(int id)
        { 
            return false;
        }
    }
}
