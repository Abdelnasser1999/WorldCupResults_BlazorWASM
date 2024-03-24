namespace WorldCupResult_BlazorWASM.Models
{
    public class Score
    {
        public string winner { get; set; }
        public string duration { get; set; }
        public MatchTimeScore fullTime { get; set; }
        public MatchTimeScore halfTime { get; set; }

    }
}
