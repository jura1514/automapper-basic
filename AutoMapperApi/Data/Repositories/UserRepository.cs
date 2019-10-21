using AutoMapperApi.Data;
using AutoMapperApi.Data.Entities;
using AutoMapperApi.Data.Interfaces;
using AutoMapperApi.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace NewsletterAPI.Data.Repositories
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        private readonly AutoMapperContext _ctx;

        public UserRepository(AutoMapperContext ctx) : base(ctx)
        {
            _ctx = ctx;
        }

        public void AddUser(User newUser)
        {
            _ctx.Add(newUser);
        }

        public void UpdateUser(User newUser)
        {
            _ctx.Update(newUser);
        }

        public void RemoveUser(User user)
        {
            _ctx.Remove(user);
        }

        public List<User> GetAllUsers()
        {
            IQueryable<User> query = _ctx.Users;

            query = query
                .Include(u => u.UserRole)
                .Include(u => u.Categories).ThenInclude(cat => cat.SubCategories);
                  

            return query.ToList();
        }

        public override bool SaveAll()
        {
            return base.SaveAll();
        }
    }
}
