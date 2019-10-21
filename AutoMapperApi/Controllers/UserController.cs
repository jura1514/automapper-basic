using AutoMapper;
using AutoMapperApi.Data.Entities;
using AutoMapperApi.Data.Interfaces;
using AutoMapperApi.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AutoMapperApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Produces("application/json")]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepo;
        private readonly IMapper _mapper;

        public UserController(
            IMapper mapper,
            IUserRepository userRepo)
        {
            _mapper = mapper;
            _userRepo = userRepo;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            try
            {
                var users = _userRepo.GetAllUsers();
                var user = users.FirstOrDefault();

                var userViewModels = _mapper.Map<IEnumerable<User>, IEnumerable<UserViewModel>>(users);
                var userViewModel = _mapper.Map<User, UserViewModel>(user);

                var userEntities = _mapper.Map<IEnumerable<UserViewModel>, IEnumerable<User>>(userViewModels);
                var userEntity = _mapper.Map<UserViewModel, User>(userViewModel);

                if (userViewModels != null)
                {
                    return Ok(userViewModels);
                }
                else
                {
                    return NotFound();
                }
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to get users");
            }
        }
    }
}
