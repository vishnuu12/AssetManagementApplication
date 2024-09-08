using DAL.Interface;
using Model.ViewModel;

namespace DAL
{
    public class AssetDal : IAssetDAL
    {
        public List<AssetModels> GetAssetBy(int id)
        {
            List<AssetModels> asset = new List<AssetModels>();
            AssetModels asset1 = new AssetModels() {Id = 1,Name="Vinith",Description="HR",AssetType="aaa",CreatedTime= DateTime.Now,CreatedBy="Dhoni",ModifiedTime=DateTime.Now,ModifiedBy="Nayak"};
            AssetModels asset2 = new AssetModels() {Id = 1,Name="ss",Description="HR",AssetType="aaa",CreatedTime= DateTime.Now,CreatedBy="Dhoni",ModifiedTime=DateTime.Now,ModifiedBy="Nayak"};
            asset.Add(asset1);
            asset.Add(asset2);
            return asset;
        }

    }
}
