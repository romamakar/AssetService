namespace AssetService.Domain.Models.Asset
{
    public class CreateAssetCommand
    {
        public int AssetId { get; set; }
        public string AssetNr { get; set; }
        public string Type { get; set; }
        public DateTime? LastCreatedDate { get; set; }
        public DateTime? LastUpdatedDate { get; set; }
        public int DimX { get; set; }
        public int DimY { get; set; }
        public int ClientId { get; set; }
    }
}
