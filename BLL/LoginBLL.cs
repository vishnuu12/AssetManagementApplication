using BLL.DtoConversions;
using BLL.Interface;
using DAL.Interface;
using Model.DtoModels;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LoginBLL : ConverToLoginModels,ILoginBLL
    {
        private readonly ILoginDAL _loginDAL;

        public LoginBLL(ILoginDAL loginDAL)
        {
            this._loginDAL = loginDAL;
        }

        public List<LoginDtoModels> GetLoginDetailsByUserName(LoginModels models)
        {
            var login = _loginDAL.GetLoginDetailByUserName(models);
            var response = this.ConvertToDtoLoginModels(login);
            return response;
        }
    }
}
