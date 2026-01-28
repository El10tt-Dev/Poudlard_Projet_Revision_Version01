using Poudlard.Domain.Enums;

namespace Poudlard.Domain.Entities;

public class Sorcier : Personne
{
    public EssenceBaguette Baguette { get; set; }
    public bool FideleVoldemort { get; set; }
}
