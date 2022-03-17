using ECommerce.Core.DataAccess;
using ECommerce.Entities.Concrete.OrderManagement;

namespace ECommerce.DataAccess.Abstract.OrderManagement
{
    public interface ICartItemDal : IEntityRepository<CartItem>
    {
    }
}
