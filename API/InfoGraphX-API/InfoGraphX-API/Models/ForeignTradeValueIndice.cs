namespace InfoGraphX_API.Models
{
    public class ForeignTradeValueIndice
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string Month { get; set; }
        public float ExportUniteValue { get; set; }
        public float ImportUniteValue { get; set; }
    }
}
