using Poudlard.Core.Interfaces.Repositories;
using Poudlard.Domain.Entities;
using Poudlard.Infrastructure.Database.Context;

namespace Poudlard.Infrastructure.Repositories;

public class EleveRepository : BaseRepository<Eleve>, IEleveRepository
{
    public EleveRepository(PoudlardContext context) : base(context)
    {
    }
}
