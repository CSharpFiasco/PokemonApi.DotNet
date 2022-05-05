using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.AspNetCore.OData.Routing.Controllers;
using Microsoft.EntityFrameworkCore;
using Pokemon.Domain.Models;
using Pokemon.Repository.Interface;

namespace Pokemon.Api.Controllers
{
    public class MoveController : ODataController
    {
        private readonly IMoveRepository _moveRepository;
        public MoveController(IMoveRepository moveRepository)
        {
            ArgumentNullException.ThrowIfNull(moveRepository, nameof(moveRepository));
            _moveRepository = moveRepository;
        }

        [HttpGet]
        [EnableQuery(PageSize = 100, MaxExpansionDepth = 2)]
        public IActionResult Get()
        {
            return Ok(_moveRepository.Get().AsNoTracking());
        }

        [HttpGet]
        [EnableQuery(MaxExpansionDepth = 2)]
        public IActionResult Get(int key)
        {
            return Ok(SingleResult.Create(_moveRepository.Get().Where(m => m.Id == key).AsNoTracking()));
        }
    }
}
