using IndiqMe.Domain;
using System.Threading.Tasks;

namespace IndiqMe.Repository
{
    public interface IUserRepository : IRepositoryGeneric<User>
    {
        Task<User> UpdatePassword(User user);
    }
}
