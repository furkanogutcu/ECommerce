using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.UserManagement.Address
{
    public class AddressState : IEntity
    {
        public int Id { get; set; }
        public int AddressCountryId { get; set; }
        public virtual AddressCountry AddressCountry { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
    }
}