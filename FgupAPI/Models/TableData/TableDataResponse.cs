using System.Collections.Generic;

namespace FgupAPI.Models.TableData
{
    public class TableDataResponse : BaseResponse
    {
        public TableDataResponse() : base()
        {
        }

        public TableDataResponse(string errMsg) : base()
        {
            ErrorMessage = errMsg;
        }

        public List<FederalDistrictData> FederalDistrictData { get; set; } = new List<FederalDistrictData>();
    }
}
