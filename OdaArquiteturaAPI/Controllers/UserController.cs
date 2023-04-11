using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdaArquiteturaAPI.Data;
using OdaArquiteturaAPI.Entity;
using OdaArquiteturaAPI.Repository;
using OdaArquiteturaAPI.Repository.Interfaces;

namespace OdaArquiteturaAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserRepository _userRepository;

    public UserController(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<User>>> GetUsers()
    {
        var user = await _userRepository.GetAllUsers();

        if (user == null || user.Count == 0)
        {
            return NotFound();
        }
        return Ok(user);
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserId(int id)
    {
        var user = await _userRepository.GetUserById(id);
        if (user == null)
        {
            return NotFound();
        }
        return Ok(user);
    }

    [HttpPost]
    public async Task<ActionResult<User>> CreateUser([FromBody] User user) {        
        return Ok(await _userRepository.AddUser(user));
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<User>> EditUser([FromBody] User user , int id)
    {
        return Ok(await _userRepository.UpdateUser(user, id));     

    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<bool>> DeleteUserById(int id)
    {
        return Ok(await _userRepository.DeleteUser(id));
    }
}
