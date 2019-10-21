using System;
using System.ComponentModel.DataAnnotations;

namespace AutoMapperApi.Data.Entities
{
    public class Role
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }

        public RoleType Type { get; set; }
    }
}

public enum RoleType
{
    Default,
    Subscriber,
    Admin
}
