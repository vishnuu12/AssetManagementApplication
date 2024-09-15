using DAL.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using Model.Models;
using Model.ViewModel;
using System.Data;
using System.Data.SqlClient;

namespace DAL
{
    public class AssetDal : IAssetDAL
    {
        //IConfiguration Key Value Pair
        private readonly IConfiguration conn;
        private readonly string? _conString;
        public AssetDal(IConfiguration _conn)
        {
            this.conn = _conn;
            this._conString = this.conn.GetConnectionString("DefaultConnection");
        }
        public List<AssetModels> GetAssetAll()
        {
            var sql = @"
select 
    AssetId ,
    BrandName ,
    Description,
    AssetType,
    CreatedTime,
    CreatedBy,
    ModifiedTime,
    ModifiedBy 
from Assets;";
            //var products = new List<AssetModels>();

            using (var connection = new SqlConnection(_conString))
            {
                connection.Open();
                var result = connection.Query<AssetModels>(sql).ToList();

                return result;
            }
        }
        public List<AssetModels> GetAssetBy(int id)
        {
            var sql = @"
select 
    AssetId ,
    BrandName ,
    Description,
    AssetType,
    CreatedTime,
    CreatedBy,
    ModifiedTime,
    ModifiedBy 
from Assets where AssetId = @AssetId;";
            //var products = new List<AssetModels>();

            using (var connection = new SqlConnection(_conString))
            {
                connection.Open();
                var result = connection.Query<AssetModels>(sql, new
                {
                    AssetId = id,
                }).ToList();

                return result;
            }
        }
        public int AddAsset(AssetModels assetModels)
        {
            var sql = @"
Insert into Assets 
(BrandName,Description,AssetType,CreatedTime,CreatedBy) 
values (@BrandName,@Description,@AssetType,@CreatedTime,@CreatedBy);"
;


            using (var connection = new SqlConnection(_conString))
            {
                var id = connection.Execute(sql, new
                {
                    assetModels.BrandName,
                    assetModels.Description,
                    assetModels.AssetType,
                    assetModels.CreatedTime,
                    assetModels.CreatedBy,
                });
                return id;

            }
        }



        public bool UpdateAsset(AssetModels assetModels)
        {
            var isUpdated = false;

            var sql = @"update Assets set BrandName = @BrandName,Description=@Description,AssetType=@AssetType,CreatedTime=@CreatedTime,CreatedBy=@CreatedBy where AssetId=@AssetId";

            using (var connection = new SqlConnection(_conString))
            {
                var result = connection.Execute(sql, new
                {
                    assetModels.AssetId,
                    assetModels.BrandName,
                    assetModels.Description,
                    assetModels.AssetType,
                    assetModels.CreatedTime,
                    assetModels.CreatedBy,
                });
                if (result > 0)
                {
                    isUpdated = true;
                }
                else
                {
                    isUpdated = false;
                }
                return isUpdated;
            }

        }
        public bool DeleteAsset(int id)
        {
            var isDeleted = false;

            var sql = @"Delete from Assets where AssetId=@AssetId";

            using ( var connection = new SqlConnection(_conString))
            {
                var result = connection.Execute(sql, new
                {
                    AssetId = id,
                });

                if(id > 0)
                {
                    isDeleted = true;
                }
                return isDeleted;
            }
           
        }
    }
}
