namespace FourFactorBetting.Populate.Dtos
{
    public class NbaRoot
    {
        public NbaInternal _internal { get; set; }
        public NbaTeamSitesOnly teamSitesOnly { get; set; }
        public int seasonScheduleYear { get; set; }
        public bool showPlayoffsClinch { get; set; }
        public NbaLinks links { get; set; }
    }
}