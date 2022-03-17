using ECommerce.Core.Entities;

namespace ECommerce.Entities.Concrete.UserManagement.Address
{
    public class AddressCountry : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Iso3 { get; set; }
        public string Iso2 { get; set; }
        public string NumericCode { get; set; }
        public string PhoneCode { get; set; }
        public string Native { get; set; }
    }
}