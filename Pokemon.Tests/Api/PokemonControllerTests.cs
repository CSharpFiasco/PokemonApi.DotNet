using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Results;
using MockQueryable.Moq;
using Moq;
using Pokemon.Api.Controllers;
using Pokemon.Repository.Interface;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pokemon.Tests.Api
{
    public class PokemonControllerTests
    {
        private readonly Mock<IPokemonRepository> _pokemonRepositoryMock = new();

        [Fact]
        public void Get_ReturnsOkQueryable()
        {
            var list = new List<Domain.Models.Pokemon> {
                new Domain.Models.Pokemon { Id = 1, }
            };

            var mock = list.BuildMock();
            _pokemonRepositoryMock.Setup(repo => repo.Get()).Returns(mock);

            var sut = new PokemonController(_pokemonRepositoryMock.Object);
            var result = sut.Get();

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actionObject = Assert.IsAssignableFrom<IQueryable<Domain.Models.Pokemon>>(actionResult.Value);

            Assert.Single(actionObject);
        }

        [Fact]
        public void GetSingle_ReturnsOkPokemon()
        {
            var list = new List<Domain.Models.Pokemon> {
                new Domain.Models.Pokemon { Id = 1, },
                new Domain.Models.Pokemon { Id = 2, },
            };

            var mock = list.BuildMock();
            _pokemonRepositoryMock.Setup(repo => repo.Get()).Returns(mock);

            var sut = new PokemonController(_pokemonRepositoryMock.Object);
            var result = sut.Get(1);

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actionObject = Assert.IsAssignableFrom<SingleResult<Domain.Models.Pokemon>>(actionResult.Value);

            Assert.Single(actionObject.Queryable);
        }
    }
}