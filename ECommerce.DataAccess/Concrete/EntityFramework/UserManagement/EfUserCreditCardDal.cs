using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.DataAccess.Abstract.UserManagement;
using ECommerce.Entities.Concrete.UserManagement;

namespace ECommerce.DataAccess.Concrete.EntityFramework.UserManagement
{
    //Simulation Class
    public class EfUserCreditCardDal : EfEntityRepositoryBase<UserCreditCard, ECommerceContext>, IUserCreditCardDal
    {
    }
}