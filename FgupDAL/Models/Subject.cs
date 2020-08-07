using Newtonsoft.Json;

namespace FgupDAL.Models
{
    public class Subject
    {
        [JsonProperty("REGION_ID")]
        public long Id { get; set; }
        [JsonProperty("PARENT_REGION_ID")]
        public long ParentRegionId { get; set; }
        [JsonProperty("REGION_NAME")]
        public string Name { get; set; }

        public int? SumTotal =>
            WomenKid.GetValueOrDefault() + WomenAdult.GetValueOrDefault() + WomenSenior.GetValueOrDefault() +
            MenKid.GetValueOrDefault() + MenAdult.GetValueOrDefault() + MenSenior.GetValueOrDefault();

        public int? WomenKid { get; set; }
        public int? WomenAdult { get; set; }
        public int? WomenSenior { get; set; }

        public int? MenKid { get; set; }
        public int? MenAdult { get; set; }
        public int? MenSenior { get; set; }
    }
}
