using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class VariantOption
    {
        public int Id { get; set; }
        public int VariantId { get; set; }
        public string Name { get; set; }
        public decimal AdditionalPrice { get; set; }
        public Variant Variant { get; set; }

    }
}
