using Arquitetura_Hexagonal.Core.Entities;

namespace Arquitetura_Hexagonal.Core.Ports;

public interface IUserRepository
{
    int Insert(User user);

    User FindByEmail(string email);

    List<User> FindAll();
}
