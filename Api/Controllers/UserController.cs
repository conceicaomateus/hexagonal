using Arquitetura_Hexagonal.Core.Entities;
using Arquitetura_Hexagonal.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[Route("Api/[controller]/[action]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService) => _userService = userService;

    [HttpGet]
    public ActionResult RecoverAll()
    {
        var users = _userService.RecoverAllUsers();

        return Ok(users);
    }

    [HttpPost]
    public ActionResult Register(User user)
    {
        var id = _userService.RegisterNewUser(user);

        return Ok(id);
    }
}
