using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoMapperApi.Models
{
    public class SubCategoryViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public CategoryViewModel Category { get; set; }
    }
}
