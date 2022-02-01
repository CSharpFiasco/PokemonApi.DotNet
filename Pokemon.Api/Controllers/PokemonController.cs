using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using Pokemon.Repository.Interface;
using Microsoft.AspNetCore.OData.Results;

namespace Pokemon.Api.Controllers
{
    public class PokemonController : ODataController
    {
        private readonly IPokemonRepository PokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            ArgumentNullException.ThrowIfNull(pokemonRepository, nameof(pokemonRepository));
            PokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [EnableQuery(MaxExpansionDepth = 2)]
        public ActionResult<IQueryable<Domain.Models.Pokemon>> Get()
        {
            return Ok(PokemonRepository.Get().AsNoTracking());
        }

        [HttpGet]
        [EnableQuery(MaxExpansionDepth = 2)]
        public ActionResult<Domain.Models.Pokemon> Get(int key)/* By odata convention, this has to be key */
        {
            var pokemon = PokemonRepository.Get().Where(p => p.Id == key).AsNoTracking();

            return Ok(SingleResult.Create(pokemon));
        }
    }
}
