using Model;
using Model.ViewModel;

namespace DAL.Interface
{
    public interface IAssetDAL
    {
        List<AssetModels> GetAssetAll();
        List<AssetModels> GetAssetBy(int id);

        int AddAsset (AssetModels assetModels);
        bool UpdateAsset(AssetModels assetModels);

        bool DeleteAsset(int id);
       
    }
}
