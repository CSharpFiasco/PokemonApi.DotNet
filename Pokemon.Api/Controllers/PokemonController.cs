using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using Pokemon.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pokemon.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PokemonController : ControllerBase
    {
        private readonly IPokemonRepository PokemonRepository;
        public PokemonController(IPokemonRepository pokemonRepository)
        {
            ArgumentNullException.ThrowIfNull(pokemonRepository, nameof(pokemonRepository));
            PokemonRepository = pokemonRepository;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        [EnableQuery]
        public IQueryable<Domain.Models.Pokemon> Get()
        {
            return PokemonRepository.Get().AsNoTracking();
        }
    }
}
