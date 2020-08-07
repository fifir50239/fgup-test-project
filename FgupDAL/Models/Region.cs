using FgupDAL.Enum;
using Newtonsoft.Json;

namespace FgupDAL.Models
{
    public class Region
    {
        [JsonProperty("REGION_ID")]
        public long Id { get; set; }
        [JsonProperty("PARENT_REGION_ID")]
        public long ParentRegionId { get; set; }
        [JsonProperty("REGION_LEVEL")]
        public RegionTypes Type { get; set; }
        [JsonProperty("REGION_NAME")]
        public string Name { get; set; }
    }
}
