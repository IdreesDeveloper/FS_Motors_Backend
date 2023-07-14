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
        public async Task<List<User>> GetAllUsers()
        {
            var usersList = await _context.Users.ToListAsync();
            return usersList;
        }
    }
}
