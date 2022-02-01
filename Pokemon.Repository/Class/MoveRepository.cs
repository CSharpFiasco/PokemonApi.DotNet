using Pokemon.Domain.Models;
using Pokemon.Repository.Context;
using Pokemon.Repository.Interface;

namespace Pokemon.Repository.Class
{
    public class MoveRepository : IMoveRepository
    {
        private readonly PokemonDatabaseContext Context;
        public MoveRepository(PokemonDatabaseContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            Context = context;
        }
        public IQueryable<Move> Get()
        {
            return Context.Move.AsQueryable();
        }
    }
}
