using Model;

namespace BLL.InterfaceBLL
{
    public interface IAssetBLL
    {
        List<AssetDtoModels> GetAssetBy(int id);
    }
}
