using System.ComponentModel.DataAnnotations;

public class Fraud
{
    [Key]
    public int Id { get; set; }

    public string ImpostorDetails { get; set; }

    public string ContactInfo { get; set; }

    public string Comments { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
}