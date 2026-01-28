namespace Poudlard.Domain.Entities;

public abstract class Personne
{
    public Guid Id { get; set; }
    public string Nom { get; set; } = null!;
    public string Prenom { get; set; } = null!;
    public DateOnly DateNaissance { get; set; }
}
