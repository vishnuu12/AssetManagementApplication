using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.DtoModels
{
    public class LoginDtoModels
    {
        public int LoginId { get; set; }

        public string? UserName { get; set; }
        public string? EncryptedPassword { get; set; }
        public DateTime CreatedTime { get; set; }

        public string? EmployeeId { get; set; }
    }
}
