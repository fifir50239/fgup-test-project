using Newtonsoft.Json;

namespace FgupDAL.Models
{
    public class Route
    {
        [JsonProperty("ID")]
        public long Id { get; set; }
        [JsonProperty("PARENT_REGION_ID")]
        public long ParentRegionId { get; set; }
        [JsonProperty("CITY_FROM_ID")]
        public long CityFromId { get; set; }
        [JsonProperty("CITY_TO_ID")]
        public long CityToId { get; set; }

        public int SumTotal => WomenKid + WomenAdult + WomenSenior + MenKid + MenAdult + MenSenior;

        [JsonProperty("VALUE_WOMEN_KID")]
        public int WomenKid { get; set; }
        [JsonProperty("VALUE_WOMEN_ADULT")]
        public int WomenAdult { get; set; }
        [JsonProperty("VALUE_WOMEN_SENIOR")]
        public int WomenSenior { get; set; }

        [JsonProperty("VALUE_MEN_KID")]
        public int MenKid { get; set; }
        [JsonProperty("VALUE_MEN_ADULT")]
        public int MenAdult { get; set; }
        [JsonProperty("VALUE_MEN_SENIOR")]
        public int MenSenior { get; set; }
    }
}
