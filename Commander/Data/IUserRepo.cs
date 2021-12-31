using System.Collections.Generic;
using UserModel.Models;
    namespace Commander.Data
    {
    public interface IUserRepo
    {
    bool SaveChanges();

    Task<List<User>> GetUsers();

    Task<User?> GetUserById(int id);

    void CreateUser(User cmd);
    void UpdateUser(User cmd);
    void DeleteUser(User cmd);

    }
}