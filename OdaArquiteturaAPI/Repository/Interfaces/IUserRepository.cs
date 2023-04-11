using OdaArquiteturaAPI.Entity;

namespace OdaArquiteturaAPI.Repository.Interfaces;

public interface IUserRepository
{
    Task<List<User>> GetAllUsers();
    Task<User> GetUserById(int id);
    Task<User> AddUser(User user);
    Task<User> UpdateUser(User user , int id);
    Task<bool> DeleteUser(int id);
}
