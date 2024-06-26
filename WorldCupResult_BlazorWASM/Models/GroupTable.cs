﻿namespace WorldCupResult_BlazorWASM.Models
{
    public class GroupTable
    {
        public int position { get; set; }
        public Team team { get; set; }
        public int playedGames { get; set; }
        public object form { get; set; }
        public int won { get; set; }
        public int draw { get; set; }
        public int lost { get; set; }
        public int points { get; set; }
        public int goalsFor { get; set; }
        public int goalsAgainst { get; set; }
        public int goalDifference { get; set; }
    }
}