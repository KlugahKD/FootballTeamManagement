namespace FootballTeamManagement.common.Entities;

public class Team : BaseEntity
{
    public string? TeamName { get; set; }
    
    public string? TeamCountry { get; set; }
    
    public string? League { get; set; }
}