using Medical_Platform.Entity;
using MongoDB.Driver;

namespace Medical_Platform.Repository
{
    public interface IUserRepository
    {


        Task<User> Get(string id);

        Task<User> Find(FilterDefinition<User> filter);

        Task Update(User user);
        Task Delete(User user);
        Task create(User user);

    }
}
