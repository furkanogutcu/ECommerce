using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.OrderManagement
{
    public class OrderItemStatus : IEntity
    {
        public int Id { get; set; }
        public string Status { get; set; }
    }
}
