using DesignPatterns_Implementations_API.Data;
using Microsoft.EntityFrameworkCore;

namespace DesignPatterns_Implementations_API.Repository;

public class Repository<T>(ApplicationDbContext context) : IRepository<T> where T : class
{
    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await context.Set<T>().ToListAsync();
    }

    public async Task<T?> GetByIdAsync(int id)
    {
        return await context.Set<T>().FindAsync(id);
    }

    public async Task<T> AddAsync(T entity)
    {
        await context.Set<T>().AddAsync(entity);
        await context.SaveChangesAsync();

        return entity;
    }

    public async Task<T> UpdateAsync(T entity)
    {
        context.Set<T>().Attach(entity);
        context.Entry(entity).State = EntityState.Modified;
        await context.SaveChangesAsync();

        return entity;
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entityToDelete = await context.Set<T>().FindAsync(id);

        if (entityToDelete == null)
        {
            return false;
        }

        context.Set<T>().Remove(entityToDelete);
        await context.SaveChangesAsync();

        return true;
    }
}