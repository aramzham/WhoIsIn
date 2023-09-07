using WhoIsIn.Models;

namespace WhoIsIn.Api.Data.Models;

public class Match
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public MatchState State { get; set; }
    public string Location { get; set; }
    public decimal Price { get; set; }

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}