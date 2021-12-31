using UserRolModel.Models;
using System.Collections.Generic;
using UserModel.Models;
using Microsoft.EntityFrameworkCore;

namespace Commander.Data{
    public class MockUserRolRepo : IUserRolRepo
    {
        private readonly CommanderContext _entityContext;
        
        public MockUserRolRepo(CommanderContext entityContext)
        {
            _entityContext = entityContext;
        }
        public void CreateUserRol(UserRol cmd)
        {
            throw new NotImplementedException();
        }

        public void DeleteUserRol(UserRol cmd)
        {
            throw new NotImplementedException();
        }
       
        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void UpdateUserRol(UserRol cmd)
        {
            throw new NotImplementedException();
        }
        public async Task<List<UserRol>> GetUserRol()
        {
            return await _entityContext.UserRol.ToListAsync();
        }

        public async Task<UserRol?> GetUserRolById(int id)
        {
             return await _entityContext.UserRol.FindAsync(id);
        }
    }
}