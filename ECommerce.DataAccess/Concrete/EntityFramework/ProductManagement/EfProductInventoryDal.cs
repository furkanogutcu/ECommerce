using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract.ProductManagement;
using ECommerce.Entities.Concrete.ProductManagement;

namespace ECommerce.DataAccess.Concrete.EntityFramework.ProductManagement
{
    public class EfProductInventoryDal : EfEntityRepositoryBase<ProductInventory, ECommerceContext>, IProductInventoryDal
    {
    }
}