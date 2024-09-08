using Model.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DtoConversions
{
    public abstract class ConvertToDtoModels
    {
        public List<AssetDtoModels> ConvertToDtoModel(List<AssetModels> asset)
        {
            List<AssetDtoModels> dtoModel = new List<AssetDtoModels>();
            foreach (var item in asset)
            {
                var tempModel = new AssetDtoModels();
                tempModel.Id = item.Id;
                tempModel.Name = item.Name;
                tempModel.Description = item.Description;
                tempModel.CreatedTime = item.CreatedTime;
                tempModel.CreatedBy = item.CreatedBy;
                tempModel.ModifiedTime = item.ModifiedTime;
                tempModel.ModifiedBy = item.ModifiedBy;
                dtoModel.Add(tempModel);
            }
            return dtoModel;
        }
    }
}
