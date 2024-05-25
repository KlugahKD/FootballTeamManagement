namespace FootballTeamManagement.common.Entities;

public class Coach : BaseEntity
{
    public string? FirtName { get; set; }
    
    public string? LastName { get; set; }

    public int? Age { get; set; }

    public int? NumberOfTrophiesWon { get; set; }
}