using System.Collections.Generic;
using ECommerce.Core.DataAccess;
using ECommerce.Core.Entities.Concrete;

namespace ECommerce.DataAccess.Abstract.UserManagement
{
    public interface IUserDal : IEntityRepository<User>
    {
        List<OperationClaim> GetClaims(User user);
    }
}