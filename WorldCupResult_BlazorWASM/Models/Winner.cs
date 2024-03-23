namespace WorldCupResult_BlazorWASM.Models
{
    public class Winner
    {
        public int id { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string tla { get; set; }
        public string crest { get; set; }
        public string address { get; set; }
        public string website { get; set; }
        public int founded { get; set; }
        public string clubColors { get; set; }
        public object venue { get; set; }
        public DateTime lastUpdated { get; set; }
    }
}