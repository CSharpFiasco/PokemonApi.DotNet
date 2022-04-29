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
        private readonly IPokemonRepository _pokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            ArgumentNullException.ThrowIfNull(pokemonRepository, nameof(pokemonRepository));
            _pokemonRepository = pokemonRepository;
        }

        [HttpGet]
        [EnableQuery(MaxExpansionDepth = 2)]
        public IActionResult Get()
        {
            return Ok(_pokemonRepository.Get().AsNoTracking());
        }

        [HttpGet]
        [EnableQuery(MaxExpansionDepth = 2)]
        public IActionResult Get(int key)/* By odata convention, this has to be key */
        {
            var pokemon = _pokemonRepository.Get().Where(p => p.Id == key).AsNoTracking();

            return Ok(SingleResult.Create(pokemon));
        }
    }
}
