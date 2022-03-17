using System;
using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.OrderManagement
{
    public class PaymentDetail : IAuditedEntity
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
