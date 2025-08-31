using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public int Priority { get; set; }
        public int ItemCount { get; set; } = 0;
        public bool IsAvailable { get; set; } = true;
        public ICollection<Product>? Products { get; set; }

    }
}
