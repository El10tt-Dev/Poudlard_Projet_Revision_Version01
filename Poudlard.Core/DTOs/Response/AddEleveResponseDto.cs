namespace Poudlard.Core.DTOs.Response;

public class EleveResponseDto
{
    public Guid Id { get; set; }
    public string NomComplet { get; set; } = string.Empty;
    public string Maison { get; set; } = string.Empty;
    public int Points { get; set; }
}
