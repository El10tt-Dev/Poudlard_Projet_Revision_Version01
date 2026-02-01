namespace Poudlard.Core.DTOs.Request;

public class AddEleveRequestDto
{
    public string Nom  { get; set; }
    public string Prenom { get; set; }
    public DateOnly DateNaissance { get; set; }
}
