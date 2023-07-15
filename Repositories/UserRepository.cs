using FS_Motors.Interfaces;
using FS_Motors.Models;
using FS_Motors.Data;

namespace FS_Motors.Repositories
{
    public class UserRepository: IUserInterface
    {
        private readonly DataContext _context;

        public UserRepository(DataContext context)
        {
            _context = context;
        }

        public async Task<List<User>> AddUser(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>?> DeleteUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }

        public async Task<List<User>> GetAllUsers()
        {
            var users = await _context.Users.ToListAsync();
            return users;
        }

        public async Task<User?> GetSingleUser(int id)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            return user;
        }

        public async Task<List<User>?> UpdateUser(int id, User request)
        {
            var user = await _context.Users.FindAsync(id);
            if (user is null)
                return null;

            user.User_Id = request.User_Id;
            user.First_Name = request.First_Name;
            user.Last_Name = request.Last_Name;
            user.Age = request.Age;
            user.Email = request.Email;
            user.Address = request.Address;

            await _context.SaveChangesAsync();

            return await _context.Users.ToListAsync();
        }
    }
}
