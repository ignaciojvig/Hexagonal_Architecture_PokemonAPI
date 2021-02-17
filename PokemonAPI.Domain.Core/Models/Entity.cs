using System;
using System.Collections.Generic;
using System.Text;

namespace AuditingEntities.Domain.Core.Models
{
    public abstract class Entity : AuditingProperties
    {
        public Guid Id { get; private set; }
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }
    }
}
