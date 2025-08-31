using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class OrderTaxAndCharge
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int TaxAndChargeId { get; set; }
        public string Name { get; set; }
        public string ChargeType { get; set; }
        public decimal ChargeAmount { get; set; }
        public string ChargeAmountType { get; set; }

        public Order Order { get; set; }
        public TaxAndCharge TaxAndCharge { get; set; }

    }
}
