using AutoMapperApi.Data.Entities;
using System.Collections.Generic;

namespace AutoMapperApi.Data.Interfaces
{
    public interface IUserRepository
    {
        void AddUser(User newUser);
        void UpdateUser(User newUser);
        void RemoveUser(User user);
        List<User> GetAllUsers();
        bool SaveAll();
    }
}
