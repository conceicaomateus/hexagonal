using Arquitetura_Hexagonal.Core.Entities;
using Arquitetura_Hexagonal.Core.Ports;
using Arquitetura_Hexagonal.Core.Services;

namespace Application.Services;

public class UserService : IUserService
{
    private readonly IUserRepository _userRepository;

    public UserService(IUserRepository userRepository) => _userRepository = userRepository;

    public User GetUserByEmail(string email)
    {
        return _userRepository.FindByEmail(email);
    }

    public List<User> RecoverAllUsers()
    {
        return _userRepository.FindAll();
    }

    public int RegisterNewUser(User user)
    {
        return _userRepository.Insert(user);
    }
}
