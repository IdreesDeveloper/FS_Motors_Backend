using FS_Motors.Models;

namespace FS_Motors.Interfaces
{
    public interface IUserInterface
    {
       public Task<List<User>> GetAllUsers();
    }
}
