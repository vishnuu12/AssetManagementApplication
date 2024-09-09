using Model;

namespace BLL.InterfaceBLL
{
    public interface IAssetBLL
    {
        List<AssetDtoModels> GetAssetAll();
        List<AssetDtoModels> GetAssetBy(int id);

        int AddAsset(AssetDtoModels assetDtoModels);

        bool UpdateAsset(AssetDtoModels assetDtoModels);
        bool DeleteAsset(int id);
    }
}
