using AuditingEntities.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Infra.Data.Interfaces
{
    public interface IPokemonRepository
    {
        Task<Pokemon> GetById(Guid id);
        Task<IEnumerable<Pokemon>> GetAll();
        void Add(Pokemon pokemon);
        void Update(Pokemon pokemon);
        void Remove(Pokemon pokemon);
        void Dispose();
    }
}
