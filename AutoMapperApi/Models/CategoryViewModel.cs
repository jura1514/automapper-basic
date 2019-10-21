using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApi.Models
{
    public class CategoryViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public UserViewModel User { get; set; }

        public List<SubCategoryViewModel> SubCategories { get; set; }
    }
}
