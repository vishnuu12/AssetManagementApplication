using BLL.InterfaceBLL;
using Microsoft.AspNetCore.Mvc;

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
    }
}
