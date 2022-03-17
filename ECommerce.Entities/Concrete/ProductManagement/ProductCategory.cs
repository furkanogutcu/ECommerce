using System;
using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.ProductManagement
{
    public class ProductCategory : IAuditedEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
