using Model.ViewModel;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

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
                tempModel.AssetId = item.AssetId;
                tempModel.BrandName = item.BrandName;
                tempModel.Description = item.Description;
                tempModel.AssetType = item.AssetType;
                tempModel.CreatedTime = item.CreatedTime;
                tempModel.CreatedBy = item.CreatedBy;
                tempModel.ModifiedTime = item.ModifiedTime;
                tempModel.ModifiedBy = item.ModifiedBy;
                dtoModel.Add(tempModel);
            }
            return dtoModel;
        }
        public AssetModels ConvertToAssetModels(AssetDtoModels assetDtoModels)
        {
            AssetModels assetModels = new AssetModels()
            {
                AssetId = assetDtoModels.AssetId,
                BrandName = assetDtoModels.BrandName,
                Description = assetDtoModels.Description,
                AssetType = assetDtoModels.AssetType,
                CreatedTime = assetDtoModels.CreatedTime,
                CreatedBy = assetDtoModels.CreatedBy,
                ModifiedTime = assetDtoModels.ModifiedTime,
                ModifiedBy = assetDtoModels.ModifiedBy,
               
            };
            return assetModels;
        }
    }
}
