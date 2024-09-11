using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Models
{
    public class RoleModels
    {
        public int RoleId { get; set; }
        public string? RoleName { get; set; }
        public string? Description { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string? ModifiedBy { get; set; }

    }
}
