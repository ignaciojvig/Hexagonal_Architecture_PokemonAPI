using AuditingEntities.Domain.Models;
using Microsoft.EntityFrameworkCore;
using PokemonAPI.Infra.Data.Context;
using PokemonAPI.Infra.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Infra.Data.Repositories
{
    public class PokemonRepository : IPokemonRepository
    {
        protected readonly PokemonDbContext Db;
        protected readonly DbSet<Pokemon> DbSet;

        public PokemonRepository(PokemonDbContext _Db)
        {
            Db = _Db;
            DbSet = Db.Set<Pokemon>();
        }

        public IUnitOfWork UnitOfWork => Db;

        public async Task<Pokemon> GetById(Guid id)
        {
            return await DbSet.AsNoTracking().FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<IEnumerable<Pokemon>> GetAll()
        {
            return await DbSet.AsNoTracking().ToListAsync();
        }

        public void Add(Pokemon pokemon)
        {
            DbSet.Add(pokemon);
        }

        public void Update(Pokemon pokemon)
        {
            DbSet.Update(pokemon);
        }

        public void Remove(Pokemon pokemon)
        {
            DbSet.Remove(pokemon);
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}
