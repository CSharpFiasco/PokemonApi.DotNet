using Pokemon.Domain.Models;

namespace Pokemon.Repository.Interface
{
    public interface IMoveRepository
    {
        IQueryable<Move> Get();
    }
}