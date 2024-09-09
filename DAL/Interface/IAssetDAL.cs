using Model.ViewModel;

namespace DAL.Interface
{
    public interface IAssetDAL
    {
        List<AssetModels> GetAssetAll();
        List<AssetModels> GetAssetBy(int id);

        int AddAsset ();
        bool UpdateAsset();

        bool DeleteAsset();
    }
}
