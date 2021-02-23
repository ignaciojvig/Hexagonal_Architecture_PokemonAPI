using Microsoft.Extensions.DependencyInjection;
using PokemonAPI.Infra.Data.Context;
using PokemonAPI.Infra.Data.Interfaces;
using PokemonAPI.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace PokemonAPI.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<PokemonDbContext>();

            services.AddScoped<IPokemonRepository, PokemonRepository>();
        }
    }
}
