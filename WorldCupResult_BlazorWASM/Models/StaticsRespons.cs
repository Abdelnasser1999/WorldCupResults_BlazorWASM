namespace WorldCupResult_BlazorWASM.Models
{
    public class StaticsRespons
    {
        public Filters filters { get; set; }
        public Area area { get; set; }
        public Competition competition { get; set; }
        public Season season { get; set; }
        public List<Standing> standings { get; set; }
    }
}