﻿using Pokemon.Repository.Context;
using Pokemon.Repository.Interface;

namespace Pokemon.Repository.Class
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDatabaseContext Context;
        public PokemonRepository(PokemonDatabaseContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            Context = context;
        }
        public IQueryable<Domain.Models.Pokemon> Get()
        {
            return Context.Pokemon.AsQueryable();
        }
    }
}
