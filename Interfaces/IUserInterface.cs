using FS_Motors.Models;

namespace FS_Motors.Interfaces
{
    public interface IUserInterface
    {
       public Task<List<User>> GetAllUsers();
        Task<User?> GetSingleUser(int id);
        Task<List<User>> AddUser(User User);
        Task<List<User>?> UpdateUser(int id, User request);
        Task<List<User>?> DeleteUser(int id);
    }
}
