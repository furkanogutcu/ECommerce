using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract.OrderManagement;
using ECommerce.Entities.Concrete.OrderManagement;

namespace ECommerce.DataAccess.Concrete.EntityFramework.OrderManagement
{
    public class EfOrderItemStatusDal : EfEntityRepositoryBase<OrderItemStatus, ECommerceContext>, IOrderItemStatusDal
    {
    }
}