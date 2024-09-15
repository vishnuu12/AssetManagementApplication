using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ViewModel
{
    //Summary
    //This model is used for Assetmodule.
    public class AssetModels
    {
        public int AssetId { get; set; }
        public string? BrandName { get; set; }
        public string? Description { get; set; }

        public string? AssetType { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string? ModifiedBy { get;set; }
    }
}
