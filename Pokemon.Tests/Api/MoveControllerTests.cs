using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Results;
using MockQueryable.Moq;
using Moq;
using Pokemon.Api.Controllers;
using Pokemon.Domain.Models;
using Pokemon.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Pokemon.Tests.Api
{
    public class MoveControllerTests
    {
        private readonly Mock<IMoveRepository> _moveRepositoryMock = new();

        [Fact]
        public void Get_ReturnsOkQueryable()
        {
            var list = new List<Move> {
                new Move { Id = 1, }
            };

            var mock = list.BuildMock();
            _moveRepositoryMock.Setup(repo => repo.Get()).Returns(mock);

            var sut = new MoveController(_moveRepositoryMock.Object);
            var result = sut.Get();

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actionObject = Assert.IsAssignableFrom<IQueryable<Move>>(actionResult.Value);

            Assert.Single(actionObject);
        }

        [Fact]
        public void GetSingle_ReturnsOkMove()
        {
            var list = new List<Move> {
                new Move { Id = 1, },
                new Move { Id = 2, },
            };

            var mock = list.BuildMock();
            _moveRepositoryMock.Setup(repo => repo.Get()).Returns(mock);

            var sut = new MoveController(_moveRepositoryMock.Object);
            var result = sut.Get(1);

            var actionResult = Assert.IsType<OkObjectResult>(result);
            var actionObject = Assert.IsAssignableFrom<SingleResult<Move>>(actionResult.Value);

            Assert.Single(actionObject.Queryable);
        }
    }
}
