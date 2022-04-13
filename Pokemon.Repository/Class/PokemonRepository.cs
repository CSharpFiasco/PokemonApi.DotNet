using Pokemon.Repository.Context;
using Pokemon.Repository.Interface;

namespace Pokemon.Repository.Class
{
    public class PokemonRepository : IPokemonRepository
    {
        private readonly PokemonDatabaseContext _context;
        public PokemonRepository(PokemonDatabaseContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            _context = context;
        }
        public IQueryable<Domain.Models.Pokemon> Get()
        {
            return _context.Pokemon.AsQueryable();
        }
    }
}
