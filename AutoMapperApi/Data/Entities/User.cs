using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapperApi.Data.Entities
{
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Email { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }

        public Guid UserRoleId { get; set; }

        [ForeignKey("UserRoleId")]
        public Role UserRole { get; set; }

        public List<Category> Categories { get; set; }
    }
}
