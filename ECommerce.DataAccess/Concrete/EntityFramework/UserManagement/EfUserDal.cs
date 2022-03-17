using System.Collections.Generic;
using System.Linq;
using ECommerce.Core.DataAccess.EntityFramework;
using ECommerce.Core.Entities.Concrete;
using ECommerce.DataAccess.Abstract.UserManagement;

namespace ECommerce.DataAccess.Concrete.EntityFramework.UserManagement
{
    public class EfUserDal : EfEntityRepositoryBase<User, ECommerceContext>, IUserDal
    {
        public List<OperationClaim> GetClaims(User user)
        {
            using (var context = new ECommerceContext())
            {
                var result = from operationClaim in context.OperationClaims
                             join userOperationClaim in context.UserOperationClaims
                                 on operationClaim.Id equals userOperationClaim.OperationClaimId
                             where userOperationClaim.UserId == user.Id
                             select new OperationClaim
                             {
                                 Id = operationClaim.Id,
                                 Name = operationClaim.Name
                             };
                return result.ToList();
            }
        }
    }
}