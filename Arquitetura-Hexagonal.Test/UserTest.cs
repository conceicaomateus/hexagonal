using Application.Services;
using Arquitetura_Hexagonal.Core.Entities;
using Arquitetura_Hexagonal.Core.Ports;
using Arquitetura_Hexagonal.Core.Services;
using DataBaseInMemory.Repositories;
using Xunit;

namespace Arquitetura_Hexagonal.Test;

public class UserTest
{
    [Fact]
    public void CreateNewUserTest()
    {
        #region Arrange

        IUserRepository userRepository = new UserRepository();
        IUserService userService = new UserService(userRepository);

        var newUser = new User()
        {
            Email = "mateus@email.com",
            Name = "Mateus Conceição",
            Password = "123456",
        };

        #endregion

        #region Act

        int userId = userService.RegisterNewUser(newUser);

        #endregion

        #region Assert

        Assert.True(userId > 0);

        #endregion
    }

    [Fact]
    public void FindUserByEmailTest()
    {
        #region Arrange

        IUserRepository userRepository = new UserRepository();
        IUserService userService = new UserService(userRepository);

        var newUser = new User()
        {
            Email = "mateus@email.com",
            Name = "Mateus Conceição",
            Password = "123456",
        };

        #endregion

        #region Act

        userService.RegisterNewUser(newUser);

        User user = userService.GetUserByEmail(newUser.Email);

        #endregion

        #region Assert

        Assert.NotNull(user);

        #endregion
    }

    [Fact]

    public void FindAllUsersTest()
    {

        #region Arrange

        IUserRepository userRepository = new UserRepository();
        IUserService userService = new UserService(userRepository);

        var firstNewUser = new User()
        {
            Email = "mateus@email.com",
            Name = "Mateus Conceição",
            Password = "123456",
        };

        var secondNewUser = new User()
        {
            Email = "mateus@email.com",
            Name = "Mateus Conceição",
            Password = "123456",
        };

        var newUsers = new User[] { firstNewUser, secondNewUser };

        #endregion

        #region Act

        for (int i = 0; i < newUsers.Length; i++)
            userService.RegisterNewUser(newUsers[i]);

        List<User> users = userService.RecoverAllUsers();

        #endregion

        #region Assert

        Assert.True(users.Count > 0);

        #endregion
    }
}