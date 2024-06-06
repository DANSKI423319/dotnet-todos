using Core.Entities;

namespace Core.Interfaces
{
    // Only useable by entities that derive from the base entity
    public interface IGenericRepository<T> where T : BaseEntity
    {
        Task<T> GetByIdAsync(int id);
    }
}