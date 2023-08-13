namespace WhoIsIn.Api.Services.Models;

public class PlayerDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string? Nickname { get; set; }
    public string? Country { get; set; }
    public string? City { get; set; }
    public string? AvatarUrl { get; set; }
    public DateTime? BirthDate { get; set; }
    public string? Bio { get; set; }
    public string Email { get; set; }
}