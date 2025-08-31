using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public decimal Discount { get; set; }
        public string DiscountType { get; set; }
        public decimal DiscountPrice { get; set; }
        public DateTime CreatedAt { get; set; }

        public Category Category { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<ProductAddon> ProductAddons { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }

    }
}
