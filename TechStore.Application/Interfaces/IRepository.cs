namespace TechStore.Application.Interfaces
{
    public interface IRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
