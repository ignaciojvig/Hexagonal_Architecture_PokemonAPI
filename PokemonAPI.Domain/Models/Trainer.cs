using AuditingEntities.Domain.Core.Models;
using AuditingEntities.Domain.Enums;
using PokemonAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditingEntities.Domain.Models
{
    public class Trainer : Entity
    {
        public string Name { get; private set; }
        public TrainerClass TrainerClass { get; private set; }

        public ICollection<Catches> Catches { get; private set; }
    }
}
