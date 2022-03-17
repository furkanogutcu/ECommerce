using System;
using ECommerce.Core.Entities;
using ECommerce.Core.Entities.Concrete;

namespace ECommerce.Entities.Concrete.UserManagement
{
    //Simulation Class
    public class UserCreditCard : IAuditedEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public string CardHolderName { get; set; }
        public byte[] AccountNumberHash { get; set; }
        public byte[] AccountNumberSalt { get; set; }
        public int ExpireMonth { get; set; }
        public int ExpireYear { get; set; }
        public byte[] CvcHash { get; set; }
        public byte[] CvcSalt { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
