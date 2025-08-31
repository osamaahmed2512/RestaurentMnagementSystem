using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class ProductAddon
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int AddonItemId { get; set; }

        public Product Product { get; set; }
        public AddonItem AddonItem { get; set; }

    }
}
