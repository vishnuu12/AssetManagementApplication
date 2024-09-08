using BLL.DtoConversions;
using BLL.InterfaceBLL;
using DAL.Interface;
using Model;

namespace BLL
{
    public class AssetBll: ConvertToDtoModels,IAssetBLL
    {
        private readonly IAssetDAL assetDAL;

        public AssetBll(IAssetDAL assetDal)
        {
            this.assetDAL = assetDal;
        }

        public List<AssetDtoModels> GetAssetBy(int id)
        { 
            var asset = assetDAL.GetAssetBy(id);
            var response = this.ConvertToDtoModel(asset);
            return response;

        }
    }
}
