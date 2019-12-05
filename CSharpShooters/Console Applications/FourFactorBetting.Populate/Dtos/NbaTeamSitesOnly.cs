namespace FourFactorBetting.Populate.Dtos
{
    public class NbaTeamSitesOnly
    {
        public int seasonStage { get; set; }
        public int seasonYear { get; set; }
        public int rosterYear { get; set; }
        public int statsStage { get; set; }
        public int statsYear { get; set; }
        public string displayYear { get; set; }
        public string lastPlayByPlay { get; set; }
        public string allPlayByPlay { get; set; }
        public string playerMatchup { get; set; }
        public string series { get; set; }
    }
}