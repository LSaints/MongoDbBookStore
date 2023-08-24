using MongoDbBookStore.Models;

namespace MongoDbBookStore.Interfaces
{
    public interface IGenericInterface <T> where T : class
    {
        public Task<List<T>> GetAsync();
        public Task<T?> GetAsync(string id);
        public Task CreateAsync(T newEntity);
        public Task UpdateAsync(string id, T updatedEntity);
        public Task RemoveAsync(string id);
    }
}
