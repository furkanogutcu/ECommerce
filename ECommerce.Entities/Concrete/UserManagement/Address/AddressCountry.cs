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
        public string? Capital { get; set; }
        public string? Native { get; set; }
        public string? Region { get; set; }
        public string? SubRegion { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}