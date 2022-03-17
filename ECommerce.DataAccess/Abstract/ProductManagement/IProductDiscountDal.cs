using ECommerce.Core.DataAccess;
using ECommerce.Entities.Concrete.ProductManagement;

namespace ECommerce.DataAccess.Abstract.ProductManagement
{
    public interface IProductDiscountDal : IEntityRepository<ProductDiscount>
    {
    }
}