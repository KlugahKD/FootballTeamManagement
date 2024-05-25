namespace FootballTeamManagement.common.Entities;

public class Player : BaseEntity
{
    public string? FirstName { get; set; }
    
    public string? LastName { get; set; }

    public int? Age { get; set; }
    
    public string Country { get; set; }

    public int JerseyNumber { get; set; }
    
    public string? Position { get; set; }
    
    public int GoalsScored { get; set; }
    
    public int Assists { get; set; }
    
    public int RedCards { get; set; }

    public int YellowCards { get; set; }
    
    public int ChancesCreated { get; set; }
    
    public int PassesCompleted { get; set; }
    
    public int ShotsOnTarget { get; set; }
}