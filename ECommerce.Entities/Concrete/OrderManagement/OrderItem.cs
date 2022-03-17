using System;
using ECommerce.Core.Entities;
using ECommerce.Entities.Concrete.ProductManagement;

namespace ECommerce.Entities.Concrete.OrderManagement
{
    public class OrderItem : IAuditedEntity
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public virtual OrderDetail OrderDetail { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int OrderItemStatusId { get; set; }
        public virtual OrderItemStatus OrderItemStatus { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
