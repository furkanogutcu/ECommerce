using System;
using ECommerce.Core.Entities;
using ECommerce.Core.Entities.Concrete;

namespace ECommerce.Entities.Concrete.OrderManagement
{
    public class OrderDetail : IAuditedEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int PaymentDetailId { get; set; }
        public virtual PaymentDetail PaymentDetail { get; set; }
        public decimal Total { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
