using AuditingEntities.Domain.Core.Models;
using AuditingEntities.Domain.Enums;
using PokemonAPI.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace AuditingEntities.Domain.Models
{
    public class Pokemon : Entity
    {
        public string Name { get; private set; }
        public PokemonType PokemonType { get; private set; }

        public ICollection<Catches> Catches { get; set; }
    }
}
