using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetService.WebApi.DTO.Asset
{
    public class CreateAssetDto
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
