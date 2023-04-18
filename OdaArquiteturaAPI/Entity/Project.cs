using OdaArquiteturaAPI.Enum;

namespace OdaArquiteturaAPI.Entity;

public class Project
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
    public StatusProject Status { get; set; } = StatusProject.Pending;
    public string?  Details { get; set; }
    public int UserId { get; set; }
    public User User { get; set; }
}
