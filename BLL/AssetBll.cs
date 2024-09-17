using BLL.DtoConversions;
using BLL.InterfaceBLL;
using DAL.Interface;
using Model;

namespace BLL
{
    public class AssetBll : ConvertToDtoModels, IAssetBLL
    {
        private readonly IAssetDAL _assetDAL;

        public AssetBll(IAssetDAL assetDal)
        {
            this._assetDAL = assetDal;
        }

        public List<AssetDtoModels> GetAssetAll()
        {
            var asset = _assetDAL.GetAssetAll();
            var response = this.ConvertToDtoModel(asset);
            return response;
        }
        public List<AssetDtoModels> GetAssetBy(int id)
        {
            var asset = _assetDAL.GetAssetBy(id);
            var response = this.ConvertToDtoModel(asset);
            return response;

        }
        public int AddAsset(AssetDtoModels assetDtoModels)
        {
            var asset = this.ConvertToAssetModels(assetDtoModels);
            var response = _assetDAL.AddAsset(asset);
            return response;
        }

       
        public bool UpdateAsset(AssetDtoModels assetDtoModels)
        {
           
           var asset = ConvertToAssetModels(assetDtoModels);
           var response = _assetDAL.UpdateAsset(asset);
            return response;
        }

        public bool DeleteAsset(int id)
        {
            
          var asset = _assetDAL.DeleteAsset(id);
          return asset;
        }
    }
}
