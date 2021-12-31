using System;
using System.Collections.Generic;
using System.Linq;
using UserModel.Models;

namespace Commander.Data
{
    public class SqlUserRepo : IUserRepo
    {
        private readonly CommanderContext _context;

        public SqlUserRepo(CommanderContext context)
        {
            _context = context;
        }

        public void CreateUser(User cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.User.Add(cmd);
        }

        public void DeleteUser(User cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }
            _context.User.Remove(cmd);
        }

        public IEnumerable<User> GetUsers()
        {
            return _context.User.ToList();
        }

        public User GetUserById(int id)
        {
            return _context.User.FirstOrDefault(p => p.Id == id);
        }

        public bool SaveChanges()
        {
            return (_context.SaveChanges() >= 0);
        }

        public void UpdateUser(User cmd)
        {
            //Nothing
        }

        Task<List<User>> IUserRepo.GetUsers()
        {
            throw new NotImplementedException();
        }

        Task<User?> IUserRepo.GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}