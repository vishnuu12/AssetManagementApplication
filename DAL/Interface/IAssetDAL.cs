using Model.ViewModel;

namespace DAL.Interface
{
    public interface IAssetDAL
    {
        List<AssetModels> GetAssetBy(int id);
    }
}
