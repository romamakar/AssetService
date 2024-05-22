using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetService.Persistence.Entities
{
    public class AssetEntity
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("asset_id")]
        public int AssetId { get; set; }

        [Column("asset_nr")]
        public string AssetNr { get; set; }

        [Column("type")]
        public string Type { get; set; }

        [Column("last_created_date")]
        public DateTime? LastCreatedDate { get; set; }

        [Column("last_updated_date")]
        public DateTime? LastUpdatedDate { get; set; }

        [Column("dim_x")]
        public int DimX { get; set; }

        [Column("dim_y")]
        public int DimY { get; set; }

        [Column("client_id")]
        public int ClientId { get; set; }
        public ClientEntity Client { get; set; }
    }
}
