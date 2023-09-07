namespace WhoIsIn.Models.Dtos;

public class MatchDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public MatchState State { get; set; }
    public string Location { get; set; }
    public decimal Price { get; set; }

    public List<PlayerDto> Players { get; set; } = new();
}