using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PokemonAPI.Infra.Data.Context
{
    public interface IUnitOfWork
    {
        Task<bool> Commit();
    }
}
