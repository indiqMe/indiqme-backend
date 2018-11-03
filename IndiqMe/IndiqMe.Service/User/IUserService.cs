using IndiqMe.Domain;
using IndiqMe.Domain.Common;
using IndiqMe.Service.Generic;

namespace IndiqMe.Service
{
    public interface IUserService : IBaseService<User>
    {
        Result<User> AuthenticationByEmailAndPassword(User user);
        new Result<User> Update(User user);
        Result<User> ChangeUserPassword(User user, string oldPassword);
    }
}
