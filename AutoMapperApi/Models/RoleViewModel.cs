using System.ComponentModel.DataAnnotations;

namespace AutoMapperApi.Models
{
    public class RoleViewModel
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public RoleType Type { get; set; }
    }
}
