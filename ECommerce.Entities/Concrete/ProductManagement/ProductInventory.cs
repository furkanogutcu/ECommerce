using System;
using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.ProductManagement
{
    public class ProductInventory : IAuditedEntity
    {
        public int Id { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public string QuantityPerUnit { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
