
namespace Pokemon.Repository.Interface
{
    public interface IPokemonRepository
    {
        IQueryable<Domain.Models.Pokemon> Get();
    }
}