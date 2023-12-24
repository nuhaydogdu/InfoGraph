namespace InfoGraphX_API.Models
{
    public class HappinessLevelByAgeGroup
    {
        public int Id { get; set; }
        public int Year { get; set; }
        public string AgeGroup { get; set; }
        public float Happy { get; set; }
        public float Medium { get; set; }
        public float UnHappy { get; set; }
    }
}
