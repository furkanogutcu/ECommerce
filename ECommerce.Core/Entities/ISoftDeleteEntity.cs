using System;

namespace ECommerce.Core.Entities
{
    public interface ISoftDeleteEntity : IEntity
    {
        public DateTime? DeletedAt { get; set; }
    }
}
