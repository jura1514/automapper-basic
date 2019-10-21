
using AutoMapper;
using AutoMapperApi.Data.Entities;
using AutoMapperApi.Models;

namespace AutoMapperApi.Data
{
    public class AutoMapperMappingProfile: Profile
    {
        public AutoMapperMappingProfile()
        {
            CreateMap<User, UserViewModel>()
                .ReverseMap();

            CreateMap<Role, RoleViewModel>()
                .ReverseMap();

            CreateMap<Category, CategoryViewModel>()
                .ReverseMap();

            CreateMap<SubCategory, SubCategoryViewModel>()
                .ReverseMap();
        }
    }
}