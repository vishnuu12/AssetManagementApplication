using BLL.InterfaceBLL;
using Microsoft.AspNetCore.Mvc;
using Model;

namespace AssetManagementApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AssetControllers : ControllerBase
    {
        private readonly IAssetBLL iAsset;
        public AssetControllers(IAssetBLL iAsset)
        {
            this.iAsset = iAsset;
        }

        [Route("all")]
        [HttpGet]

        public IActionResult GetAssetAll()
        {
            var result = iAsset.GetAssetAll();
            var response = new
            {
                status = 200,
                response = result,
                message = "Datas retrived",

            };
            return Ok(response);
        }
            
        [Route("{id}")]
        [HttpGet]
        public IActionResult GetAssetBy(int id)
        {
            var result = iAsset.GetAssetBy(id);
            var response = new
            {
                status = 200,
                response = result,
                message = "Datas retrived",

            };
            return Ok(response);

        }
        [Route("Add")]
        [HttpPost]

        public int AddAsset([FromBody] AssetDtoModels assetDtoModels)
        {
            var response = iAsset.AddAsset(assetDtoModels);
            return response;
        }

        [Route("Update")]
        [HttpPost]

        public bool UpdateAsset([FromBody] AssetDtoModels assetDtoModels)
        {
            var response = iAsset.UpdateAsset(assetDtoModels);
            return response;
        }

        [Route("delete/{id}")]
        [HttpDelete]

        public bool DeleteAsset(int id)
        {
            var response = iAsset.DeleteAsset(id);
            return response;
        }
    }
}
