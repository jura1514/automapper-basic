using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AutoMapperApi.Models
{
    public class UserViewModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [EmailAddress]
        public string Email { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }

        public RoleViewModel UserRole { get; set; }

        public List<CategoryViewModel> Categories { get; set; }
    }
}
