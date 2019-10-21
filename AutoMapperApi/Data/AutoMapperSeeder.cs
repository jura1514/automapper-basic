using AutoMapperApi.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApi.Data
{
    public class AutoMapperSeeder
    {
        private readonly AutoMapperContext _ctx;

        public AutoMapperSeeder(AutoMapperContext ctx)
        {
            _ctx = ctx;
        }

        public async Task SeedAsync()
        {
            _ctx.Database.EnsureCreated();

            var user = _ctx.Users.FirstOrDefault();

            if (user == null)
            {
                AddData();

                await _ctx.SaveChangesAsync();
            }
        }

        public void AddData()
        {
            var role1 = new Role
            {
                Id = Guid.NewGuid(),
                Type = RoleType.Admin,
                Name = "Admin User Role",
                Description = "Admin User Role Description"
            };

            var role2 = new Role
            {
                Id = Guid.NewGuid(),
                Type = RoleType.Subscriber,
                Name = "Subscriber User Role",
                Description = "Subscriber User Role Description"
            };

            var role3 = new Role
            {
                Id = Guid.NewGuid(),
                Type = RoleType.Default,
                Name = "Default User Role",
                Description = "Default User Role Description"
            };

            _ctx.Add(role1);
            _ctx.Add(role2);
            _ctx.Add(role3);

            var user1 = new User
            {
                Id = Guid.NewGuid(),
                Username = "User1-admin",
                Email = "test@mail.com",
                Age = 23,
                Address = "Aberdeen, UK",
                UserRoleId = role1.Id,
                UserRole = role1
            };

            var user2 = new User
            {
                Id = Guid.NewGuid(),
                Username = "User2-subscriber",
                Email = "test2@mail.com",
                Age = 24,
                Address = "Aberdeen, UK",
                UserRoleId = role2.Id,
                UserRole = role2
            };

            _ctx.Add(user1);
            _ctx.Add(user2);

            var category1 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Category 1",
                Description = "Category 1 Desc",
                User = user1,
                UserId = user1.Id
            };

            var category2 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Category 2",
                Description = "Category 2 Desc",
                User = user1,
                UserId = user1.Id
            };

            var category3 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Category 3",
                Description = "Category 3 Desc",
                User = user2,
                UserId = user2.Id
            };

            var category4 = new Category
            {
                Id = Guid.NewGuid(),
                Name = "Category 4",
                Description = "Category 4 Desc",
                User = user2,
                UserId = user2.Id
            };

            _ctx.Add(category1);
            _ctx.Add(category2);
            _ctx.Add(category3);
            _ctx.Add(category4);

            var subCategory1 = new SubCategory
            {
                Id = Guid.NewGuid(),
                Name = "Sub Category 1",
                Description = "Sub Category 1 Desc",
                Category = category1,
                CategoryId = category1.Id
            };

            var subCategory2 = new SubCategory
            {
                Id = Guid.NewGuid(),
                Name = "Sub Category 2",
                Description = "Sub Category 2 Desc",
                Category = category1,
                CategoryId = category1.Id
            };

            var subCategory3 = new SubCategory
            {
                Id = Guid.NewGuid(),
                Name = "Sub Category 3",
                Description = "Sub Category 3 Desc",
                Category = category2,
                CategoryId = category2.Id
            };

            var subCategory4 = new SubCategory
            {
                Id = Guid.NewGuid(),
                Name = "Sub Category 4",
                Description = "Sub Category 4 Desc",
                Category = category2,
                CategoryId = category2.Id
            };

            _ctx.Add(subCategory1);
            _ctx.Add(subCategory2);
            _ctx.Add(subCategory3);
            _ctx.Add(subCategory4);
        }
    }
}