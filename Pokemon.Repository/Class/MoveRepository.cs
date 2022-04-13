using Pokemon.Domain.Models;
using Pokemon.Repository.Context;
using Pokemon.Repository.Interface;

namespace Pokemon.Repository.Class
{
    public class MoveRepository : IMoveRepository
    {
        private readonly PokemonDatabaseContext _context;
        public MoveRepository(PokemonDatabaseContext context)
        {
            ArgumentNullException.ThrowIfNull(context);

            _context = context;
        }
        public IQueryable<Move> Get()
        {
            return _context.Move.AsQueryable();
        }
    }
}
