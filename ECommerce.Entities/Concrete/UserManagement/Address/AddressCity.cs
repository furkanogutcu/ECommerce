using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.UserManagement.Address
{
    public class AddressCity : IEntity
    {
        public int Id { get; set; }
        public int AddressStateId { get; set; }
        public virtual AddressState AddressState { get; set; }
        public string Name { get; set; }
    }
}
