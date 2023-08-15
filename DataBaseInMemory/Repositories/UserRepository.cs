using Arquitetura_Hexagonal.Core.Entities;
using Arquitetura_Hexagonal.Core.Ports;

namespace DataBaseInMemory.Repositories;

public class UserRepository : IUserRepository
{
    private static int AutoIncrement = 1;

    private static List<User> Users = new();

    public List<User> FindAll()
    {
        return Users;
    }

    public User FindByEmail(string email)
    {
        return Users.Find(w => w.Email == email);
    }

    public int Insert(User user)
    {
        User newUser = new()
        {
            Email = user.Email,
            Id = AutoIncrement,
            Name = user.Name,
            Password = user.Password,
        };

        Users.Add(newUser);

        AutoIncrement++;

        return newUser.Id;
    }
}
