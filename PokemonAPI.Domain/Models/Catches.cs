using AuditingEntities.Domain.Core.Models;
using AuditingEntities.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI.Domain.Models
{
    public class Catches : Entity
    {
        public Guid TrainerId { get; private set; }
        public Trainer Trainer { get; private set; }

        public Guid PokemonId { get; private set; }
        public Pokemon Pokemon { get; private set; }
    }
}
