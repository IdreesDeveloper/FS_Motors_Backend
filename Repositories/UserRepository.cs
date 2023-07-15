using FS_Motors.Interfaces;
using FS_Motors.Models;
using SuperHeroApiDotNet7.Data;

namespace FS_Motors.Repositories
{
    public class UserRepository: IUserInterface
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public Task<List<User>> AddUser(User User)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>?> DeleteUser(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetAllUsers()
        {
            var usersList = await _context.Users.ToListAsync();
            return usersList;
        }

        public Task<User?> GetSingleUser(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<User>?> UpdateUser(int id, User request)
        {
            throw new NotImplementedException();
        }
    }
}
