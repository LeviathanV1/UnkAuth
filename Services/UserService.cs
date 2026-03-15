using MongoDB.Driver;
using UnkAuthProject.Models;
using System.Threading.Tasks;

namespace UnkAuthProject.Services
{
    public class UserService
    {
        private readonly IMongoCollection<User> _users;

        public UserService(IMongoDatabase database)
        {
            _users = database.GetCollection<User>("Users");
        }

        public async Task<User?> GetByUsernameAsync(string username)
        {
            try
            {
                return await _users.Find(u => u.Username == username).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error getting user by username: {ex.Message}");
                return null;
            }
        }

        public async Task UpdateUserAsync(User user)
        {
            try
            {
                await _users.ReplaceOneAsync(u => u.Id == user.Id, user);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating user: {ex.Message}");
                throw;
            }
        }
    }
}
