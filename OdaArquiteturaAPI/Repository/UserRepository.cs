using Microsoft.EntityFrameworkCore;
using OdaArquiteturaAPI.Data;
using OdaArquiteturaAPI.Entity;
using OdaArquiteturaAPI.Repository.Interfaces;

namespace OdaArquiteturaAPI.Repository;

public class UserRepository : IUserRepository
{
    private readonly OdaDBContext _dbContext;
    public UserRepository(OdaDBContext odaDBContext)
    {
        _dbContext = odaDBContext;

    }

    public async Task<List<User>> GetAllUsers()
    {
        return await _dbContext.Users.ToListAsync();
    }

    public async Task<User> GetUserById(int id)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(obj => obj.Id == id);
    }

    public async Task<User> AddUser(User user)
    {
         _dbContext.Users.Add(user);
         _dbContext.SaveChanges();
        return  user;
    }

    public async Task<User> UpdateUser(User user, int id)
    {
        User userById = await GetUserById(id);
        if (userById == null)
        {
            throw new Exception($"Não achamos o User pelo Id: {id}");
        }

       userById.Name = user.Name;
       userById.Email = user.Email;

        _dbContext.Users.Update(userById);

        return userById;
    }

    public async Task<bool> DeleteUser(int id)
    {
        User userById = await GetUserById(id);
        if (userById == null)
        {
            throw new Exception($"Não achamos o User pelo Id: {id}");
        }

        _dbContext.Users.Remove(userById);
        _dbContext.SaveChanges();

        return true;
    }

  
}
