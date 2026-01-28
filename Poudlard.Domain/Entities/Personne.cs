namespace Poudlard.Domain.Entities;

public abstract class Personne
{
    public Guid Id { get; set; }
    public string Nom { get; set; }
    public string Prenom { get; set; }
    public DateOnly DateNaissance { get; set; }
}
