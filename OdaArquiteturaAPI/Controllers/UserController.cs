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
        return Ok(await _userRepository.GetAllUsers());
    }


    [HttpGet("{id}")]
    public async Task<ActionResult<User>> GetUserId(int id)
    {
        return Ok(await _userRepository.GetUserById(id));
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
