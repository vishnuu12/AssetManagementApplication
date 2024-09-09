using BLL.DtoConversions;
using BLL.InterfaceBLL;
using DAL.Interface;
using Model;

namespace BLL
{
    public class AssetBll : ConvertToDtoModels, IAssetBLL
    {
        private readonly IAssetDAL assetDAL;

        public AssetBll(IAssetDAL assetDal)
        {
            this.assetDAL = assetDal;
        }

        public List<AssetDtoModels> GetAssetAll()
        {
            var asset = assetDAL.GetAssetAll();
            var response = this.ConvertToDtoModel(asset);
            return response;
        }
        public List<AssetDtoModels> GetAssetBy(int id)
        {
            var asset = assetDAL.GetAssetBy(id);
            var response = this.ConvertToDtoModel(asset);
            return response;

        }
        public int AddAsset(AssetDtoModels assetDtoModels)
        {
            //var asset = ConvertToDtoModel(assetDtoModels);
            //var response = assetDAL.AddAsset(asset);
            return 0;
        }
        public bool UpdateAsset(AssetDtoModels assetDtoModels)
        {
           
            return true;
        }

        public bool DeleteAsset(int id)
        {
            //var asset = ConvertToDtoModel(assetDtoModels);
            //var response = assetDAL.AddAsset(asset);
            return true;
        }
    }
}
