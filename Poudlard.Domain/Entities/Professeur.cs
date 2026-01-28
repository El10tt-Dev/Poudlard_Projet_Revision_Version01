using Poudlard.Domain.Enums;

namespace Poudlard.Domain.Entities;

public class Professeur : Sorcier
{
    public string CourAttribue { get; set; }
    public bool ChefMaison { get; set; }
    public MaisonAttribuee Maison { get; set; }
}
