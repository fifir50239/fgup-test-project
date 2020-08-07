using System.Collections.Generic;

namespace FgupAPI.Models.TableData
{
    public class FederalDistrictData : TableValues
    {
        public string Name { get; set; }
        public List<SubjectData> SubjectData { get; set; } = new List<SubjectData>();
    }
}
