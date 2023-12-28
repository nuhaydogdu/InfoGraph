namespace InfoGraphX_API.Models
{
    public class HappinesRates
    {
        public int Id { get; set; }
        public int HappyRate { get; set; }

        public int MediumRate { get; set; }

        public int UpsetRate { get; set; }

        public string ?AgeInterval { get; set; }

        public int HappinesRatesId { get; set; }
    }
}
