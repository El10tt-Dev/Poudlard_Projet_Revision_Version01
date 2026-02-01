using Microsoft.EntityFrameworkCore;
using Poudlard.Core.Interfaces.Repositories;
using Poudlard.Infrastructure.Database.Context;

namespace Poudlard.Infrastructure.Repositories;

public class BaseRepository<TEntity> : IBaseRepository<TEntity>
    where TEntity : class
{
    protected readonly PoudlardContext _context;

    public BaseRepository(PoudlardContext context)
    {
        _context = context;
    }

    public async Task<TEntity> AddAsync(TEntity entity)
    {
        await _context.Set<TEntity>().AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<IEnumerable<TEntity>> GetAllAsync()
    {
        return await _context.Set<TEntity>().ToListAsync();

    }

    public async Task<TEntity?> GetByIdAsync(Guid id)
    {
        return await _context.Set<TEntity>().FindAsync(id);
    }

    public async Task UpdateAsync (TEntity entity)
    {
        _context.Set<TEntity>().Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync (Guid id)
    {
        var entity= await _context.Set<TEntity>().FindAsync(id);
        if(entity != null)
        {
            _context.Remove(entity);
            await _context.SaveChangesAsync();
        }

    }

}
