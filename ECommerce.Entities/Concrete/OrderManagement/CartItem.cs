using System;
using ECommerce.Core.Entities;
using ECommerce.Entities.Concrete.ProductManagement;

namespace ECommerce.Entities.Concrete.OrderManagement
{
    public class CartItem : IAuditedEntity
    {
        public int Id { get; set; }
        public int ShoppingSessionId { get; set; }
        public virtual ShoppingSession ShoppingSession { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
