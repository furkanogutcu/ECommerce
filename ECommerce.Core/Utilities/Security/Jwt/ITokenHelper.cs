using System.Collections.Generic;
using ECommerce.Core.Entities.Concrete;

namespace ECommerce.Core.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
