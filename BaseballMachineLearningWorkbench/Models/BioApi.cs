namespace BaseballMachineLearningWorkbench.Models
{
    public class BioApi
    {
        public string FullPlayerName { get; set; }// From MLBBaseballBatterSeasonPrediction
        public int YearsPlayed { get; set; }// From MLBBaseballBatter
        public int HR { get; set; }// From MLBBaseballBatter
        public int TotalPlayerAwards { get; set; }// From MLBBaseballBatter
        public double HallOfFameProbability { get; set; }// From MLBBaseballBatterSeasonPrediction

        public int LastYearPlayed { get; set; }
    }
}
