using System.Collections.Generic;
using UserRolModel.Models;
    namespace Commander.Data
    {
    public interface IUserRolRepo
    {
    bool SaveChanges();

    Task<List<UserRol>> GetUserRol();

    Task<UserRol?> GetUserRolById(int id);

    void CreateUserRol(UserRol cmd);
    void UpdateUserRol(UserRol cmd);
    void DeleteUserRol(UserRol cmd);
    }
}

