using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public string UserId { get; set; }
        public string OrderNumber { get; set; }
        public string OrderType { get; set; }
        public string Status { get; set; }
        public DateTime Date { get; set; }
        public int PaymentAccountId { get; set; }
        public string PaymentStatus { get; set; }
        public string OrderNote { get; set; }
        public decimal SubTotal { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime CreatedAt { get; set; }


        public PaymentAccount PaymentAccount { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public ICollection<OrderTaxAndCharge> OrderTaxesAndCharges { get; set; }

    }
}
