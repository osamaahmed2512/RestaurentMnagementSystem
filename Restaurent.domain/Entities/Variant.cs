using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class Variant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsRequired { get; set; }
        public int MinSelected { get; set; }
        public int MaxSelected { get; set; }
        public bool IsAllowMultipleSelection { get; set; }
        public string UniqueName { get; set; }

        public ICollection<VariantOption> VariantOptions { get; set; }
        public ICollection<ProductVariant> ProductVariants { get; set; }

    }
}
