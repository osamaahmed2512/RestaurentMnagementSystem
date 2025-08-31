using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurent.domain.Entities
{
    public class PaymentAccount
    {
        public int Id { get; set; }
        public int PaymentMethodId { get; set; }
        public string AccountName { get; set; }
        public string ClientId { get; set; }
        public string ClientSecret { get; set; }
        public string WebhookId { get; set; }
        public bool SandboxMode { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        public ICollection<Order> Orders { get; set; }

    }
}
