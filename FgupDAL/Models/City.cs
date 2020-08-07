using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;


namespace FgupDAL.Models
{
    public class City
    {
        [JsonProperty("CITY_OKATO_ID")]
        [Key]
        public long OkatoId { get; set; }
        [JsonProperty("NAME")]
        public string Name { get; set; }
        [JsonProperty("PARENT_REGION_ID")]
        public long ParentRegionId { get; set; }
        [JsonProperty("FO_ID")]
        public long FederalDistritId { get; set; }
    }
}
