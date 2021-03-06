using ECommerce.Core.DataAccess;
using ECommerce.Entities.Concrete.UserManagement.Address;

namespace ECommerce.DataAccess.Abstract.UserManagement.Address
{
    public interface IAddressCountryDal : IEntityRepository<AddressCountry>
    {
    }
}