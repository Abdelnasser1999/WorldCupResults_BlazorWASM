namespace WorldCupResult_BlazorWASM.Models
{
    public class Standing
    {
        public string stage { get; set; }
        public string type { get; set; }
        public string group { get; set; }
        public List<GroupTable> table { get; set; }
    }
}