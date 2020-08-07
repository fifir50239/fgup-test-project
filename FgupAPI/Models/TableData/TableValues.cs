namespace FgupAPI.Models.TableData
{
    public abstract class TableValues
    {
        public int SumTotal => WomenKid + WomenAdult + WomenSenior + MenKid + MenAdult + MenSenior;

        public int WomenKid { get; set; }
        public int WomenAdult { get; set; }
        public int WomenSenior { get; set; }

        public int MenKid { get; set; }
        public int MenAdult { get; set; }
        public int MenSenior { get; set; }
    }
}
