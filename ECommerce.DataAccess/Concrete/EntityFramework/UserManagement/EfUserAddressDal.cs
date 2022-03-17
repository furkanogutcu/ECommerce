using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract.UserManagement;
using ECommerce.Entities.Concrete.UserManagement;

namespace ECommerce.DataAccess.Concrete.EntityFramework.UserManagement
{
    public class EfUserAddressDal : EfEntityRepositoryBase<UserAddress, ECommerceContext>, IUserAddressDal
    {
    }
}