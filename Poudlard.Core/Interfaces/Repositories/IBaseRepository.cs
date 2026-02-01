namespace Poudlard.Core.Interfaces.Repositories;

public interface IBaseRepository<TEntity>
    where TEntity : class   
{
    //Create, Read, Update, Delete
    Task<IEnumerable<TEntity>> GetAllAsync();
    Task<TEntity?> GetByIdAsync(Guid id);
    Task<TEntity> AddAsync(TEntity entity);
    Task UpdateAsync(TEntity entity);
    Task DeleteAsync(Guid id);

}
