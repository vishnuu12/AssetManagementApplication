using DAL.Interface;
using Dapper;
using Microsoft.Extensions.Configuration;
using Model.ViewModel;
using System.Data.SqlClient;

namespace DAL
{
    public class AssetDal : IAssetDAL
    {
        private readonly IConfiguration conn;
        private readonly string _conString = string.Empty;
        public AssetDal(IConfiguration _conn) 
        {
            this.conn = _conn;
            this._conString = this.conn.GetConnectionString("DefaultConnection");
        }
        public List<AssetModels> GetAssetAll()
        {
            var sql = @"
select 
    AssetId as Id,
    BrandName as Name,
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
    AssetId as Id,
    BrandName as Name,
    Description,
    AssetType,
    CreatedTime,
    CreatedBy,
    ModifiedTime,
    ModifiedBy 
from Assets where BrandName = @AssetId;";
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
