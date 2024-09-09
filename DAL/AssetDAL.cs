﻿using DAL.Interface;
using Model.ViewModel;

namespace DAL
{
    public class AssetDal : IAssetDAL
    {
        public List<AssetModels> GetAssetAll()
        {
            List<AssetModels> asset = new List<AssetModels>();
            AssetModels asset1 = new AssetModels() {Id = 1,Name="Vinith",Description="HR",AssetType="aaa",CreatedTime= DateTime.Now,CreatedBy="Dhoni",ModifiedTime=DateTime.Now,ModifiedBy="Nayak"};
            AssetModels asset2 = new AssetModels() {Id = 2,Name="ss",Description="HR",AssetType="aaa",CreatedTime= DateTime.Now,CreatedBy="Dhoni",ModifiedTime=DateTime.Now,ModifiedBy="Nayak"};
            asset.Add(asset1);
            asset.Add(asset2);
            return asset;
        }
        public List<AssetModels> GetAssetBy(int id)
        {
            List<AssetModels> asset = new List<AssetModels>();
            AssetModels asset1 = new AssetModels() { Id = 1, Name = "Vinith", Description = "HR", AssetType = "aaa", CreatedTime = DateTime.Now, CreatedBy = "Dhoni", ModifiedTime = DateTime.Now, ModifiedBy = "Nayak" };
            AssetModels asset2 = new AssetModels() { Id = 2, Name = "ss", Description = "HR", AssetType = "aaa", CreatedTime = DateTime.Now, CreatedBy = "Dhoni", ModifiedTime = DateTime.Now, ModifiedBy = "Nayak" };
            asset.Add(asset1);
            asset.Add(asset2);
            return asset.Where(x => x.Id == id).ToList();
        }
        public int AddAsset()
        {
           
            return 0;
        }
        public bool UpdateAsset()
        {

            return true;
        }
        public bool DeleteAsset()
        {

            return true;
        }
    }
}
