using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class TaxAndCharge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ChargeType { get; set; }
        public decimal ChargeAmount { get; set; }
        public string ChargeAmountType { get; set; }
        public bool IsAvailable { get; set; }

        public ICollection<OrderTaxAndCharge> OrderTaxesAndCharges { get; set; }

    }
}
