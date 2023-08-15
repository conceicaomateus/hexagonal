using Arquitetura_Hexagonal.Core.Entities;

namespace Arquitetura_Hexagonal.Core.Services;

public interface IUserService
{
    List<User> RecoverAllUsers();

    User GetUserByEmail(string email);

    int RegisterNewUser(User user);
}
