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
        private readonly IConfiguration _conn;
        private readonly string? _conString;
        public AssetDal(IConfiguration conn)
        {
            this._conn = conn;
            this._conString = this._conn.GetConnectionString("DefaultConnection");
        }
        public List<AssetModels> GetAssetAll()
        {
            List<AssetModels> assetModels = new List<AssetModels>();
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

            try
            {
                using (var connection = new SqlConnection(_conString))
                {
                    connection.Open();
                    assetModels = connection.Query<AssetModels>(sql).ToList();


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return assetModels;
        }
        public List<AssetModels> GetAssetBy(int id)
        {
            List<AssetModels> assetModels = new List<AssetModels>();
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

            try
            {
                using (var connection = new SqlConnection(_conString))
                {
                    connection.Open();
                    assetModels = connection.Query<AssetModels>(sql, new
                    {
                        AssetId = id,
                    }).ToList();

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return assetModels;
        }
        public int AddAsset(AssetModels assetModels)
        {
            int assetId = 0;
            var sql = @"
Insert into Assets 
(BrandName,Description,AssetType,CreatedTime,CreatedBy) 
values (@BrandName,@Description,@AssetType,@CreatedTime,@CreatedBy);"
;
            try
            {

                using (var connection = new SqlConnection(_conString))
                {
                    assetId = connection.Execute(sql, new
                    {
                        assetModels.BrandName,
                        assetModels.Description,
                        assetModels.AssetType,
                        assetModels.CreatedTime,
                        assetModels.CreatedBy,
                    });


                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }

            return assetId;
        }



        public bool UpdateAsset(AssetModels assetModels)
        {
            var isUpdated = false;

            var sql = @"update Assets set BrandName = @BrandName,Description=@Description,AssetType=@AssetType,CreatedTime=@CreatedTime,CreatedBy=@CreatedBy where AssetId=@AssetId";

            try
            {
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

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }
            return isUpdated;
        }
        public bool DeleteAsset(int id)
        {

            var isDeleted = false;

            var sql = @"Delete from Assets where AssetId=@AssetId";

            try
            {
                using (var connection = new SqlConnection(_conString))
                {
                    var result = connection.Execute(sql, new
                    {
                        AssetId = id,
                    });

                    if (id > 0)
                    {
                        isDeleted = true;
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong.\n" + e.Message);
            }

            return isDeleted;
        }
    }
}
