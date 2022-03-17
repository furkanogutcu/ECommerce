using System;
using ECommerce.Core.Entities;
using ECommerce.Core.Entities.Concrete;
using ECommerce.Entities.Concrete.UserManagement.Address;

namespace ECommerce.Entities.Concrete.UserManagement
{
    public class UserAddress : IAuditedEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int AddressCityId { get; set; }
        public virtual AddressCity AddressCity { get; set; }
        public string Address { get; set; }
        public string GsmNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? ModifiedAt { get; set; }
    }
}
