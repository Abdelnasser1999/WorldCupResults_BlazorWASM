using static System.Formats.Asn1.AsnWriter;

namespace WorldCupResult_BlazorWASM.Models
{
    public class Match
    {
        public Area area { get; set; }
        public Competition competition { get; set; }
        public Season season { get; set; }
        public int id { get; set; }
        public DateTime utcDate { get; set; }
        public string status { get; set; }
        public int matchday { get; set; }
        public string stage { get; set; }
        public string group { get; set; }
        public DateTime lastUpdated { get; set; }
        public Team homeTeam { get; set; }
        public Team awayTeam { get; set; }
        public Score score { get; set; }
        public List<Referee> referees { get; set; }
    }
}
