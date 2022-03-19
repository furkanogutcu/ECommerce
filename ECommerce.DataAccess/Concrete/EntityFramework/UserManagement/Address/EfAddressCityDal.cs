using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract.UserManagement.Address;
using ECommerce.Entities.Concrete.UserManagement.Address;

namespace ECommerce.DataAccess.Concrete.EntityFramework.UserManagement.Address
{
    public class EfAddressCityDal : EfEntityRepositoryBase<AddressCity, ECommerceContext>, IAddressCityDal
    {
    }
}