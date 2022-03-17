using System;
using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.ProductManagement
{
    public class ProductImage : IAuditedEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public string ImagePath { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
