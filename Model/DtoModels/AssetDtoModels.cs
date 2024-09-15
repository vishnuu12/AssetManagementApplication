namespace Model
{
    public class AssetDtoModels
    {
        public int AssetId { get; set; }
        public string? BrandName { get; set; }
        public string? Description { get; set; }

        public string? AssetType { get; set; }
        public DateTime CreatedTime { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime ModifiedTime { get; set; }
        public string? ModifiedBy { get; set; }
    }
}
