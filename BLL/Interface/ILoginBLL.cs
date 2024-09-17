using Model.DtoModels;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interface
{
    public interface ILoginBLL
    {
        List<LoginDtoModels> GetLoginDetailsByUserName(LoginModels models);
    }
}
