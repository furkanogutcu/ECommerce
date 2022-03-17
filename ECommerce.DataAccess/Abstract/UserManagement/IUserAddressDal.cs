using ECommerce.Core.DataAccess;
using ECommerce.Entities.Concrete.UserManagement;

namespace ECommerce.DataAccess.Abstract.UserManagement
{
    public interface IUserAddressDal : IEntityRepository<UserAddress>
    {
    }
}