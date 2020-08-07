using System.Collections.Generic;

namespace FgupAPI.Models.TableData
{
    public class SubjectData : TableValues
    {
        public string Name { get; set; }
        public List<InsideRegionData> InsideRegionData { get; set; } = new List<InsideRegionData>();
    }
}
