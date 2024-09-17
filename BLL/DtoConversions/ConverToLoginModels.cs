using Microsoft.AspNetCore.Mvc.Diagnostics;
using Model.DtoModels;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DtoConversions
{
    public abstract class ConverToLoginModels
    {
        public List<LoginDtoModels> ConvertToDtoLoginModels(List<LoginModels> loginModels)
        {
            List<LoginDtoModels> loginDtoModels = new List<LoginDtoModels>();
            foreach (var item in loginModels)
            {
                var tempModel = new LoginDtoModels();
                tempModel.LoginId = item.LoginId;
                tempModel.UserName = item.UserName;
                tempModel.EncryptedPassword = item.EncryptedPassword;
                tempModel.CreatedTime = item.CreatedTime;
                tempModel.EmployeeId = item.EmployeeId;
                loginDtoModels.Add(tempModel);
            }
            return loginDtoModels;
           
        }
    }
}
