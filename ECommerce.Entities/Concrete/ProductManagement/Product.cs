using System;
using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.ProductManagement
{
    public class Product : IAuditedEntity, ISoftDeleteEntity
    {
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public virtual ProductCategory ProductCategory { get; set; }
        public int ProductInventoryId { get; set; }
        public virtual ProductInventory ProductInventory { get; set; }
        public int? ProductDiscountId { get; set; }
        public virtual ProductDiscount ProductDiscount { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public decimal UnitPrice { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
        public DateTime? DeletedAt { get; set; }
    }
}
