namespace NZWalks.API.Models.Domain
{
	public class Difficulty
	{
        public Guid Id { get; set; }
        public DifficultyLevels Name { get; set; }
    }
}

public enum DifficultyLevels
{
    easy, medium, hard
}
