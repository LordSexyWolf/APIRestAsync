using UserModel.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data{
    public class MockUserRepo : IUserRepo
    {
        private readonly CommanderContext _entityContext;
        
        public MockUserRepo(CommanderContext entityContext)
        {
            _entityContext = entityContext;
        }
        public void CreateUser(User cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(User cmd)
        {
            throw new NotImplementedException();
        }

       
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateUser(User cmd)
        {
            throw new NotImplementedException();
        }

        public async Task<List<User>> GetUsers()
        {
            return await _entityContext.User.ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
             return await _entityContext.User.FindAsync(id);
        }
    }

    
}