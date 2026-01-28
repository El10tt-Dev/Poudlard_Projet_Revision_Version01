using Poudlard.Domain.Enums;

namespace Poudlard.Domain.Entities;

public class Eleve : Sorcier
{
    public AnneeEtude Annee { get; set; }
    public MaisonAttribuee Maison { get; set; }
    public int? PointGagne { get; set; }
    public int? PointPerdu { get; set; }
}
