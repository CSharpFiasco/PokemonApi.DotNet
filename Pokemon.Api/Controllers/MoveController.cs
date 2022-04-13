using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.OData.Query;
using Microsoft.AspNetCore.OData.Results;
using Microsoft.EntityFrameworkCore;
using Pokemon.Domain.Models;
using Pokemon.Repository.Interface;

namespace Pokemon.Api.Controllers
{
    public class MoveController : ControllerBase
    {
        private readonly IMoveRepository _moveRepository;
        public MoveController(IMoveRepository moveRepository)
        {
            ArgumentNullException.ThrowIfNull(moveRepository, nameof(moveRepository));
            _moveRepository = moveRepository;
        }

        [HttpGet]
        [EnableQuery(MaxExpansionDepth = 2)]
        public ActionResult<IQueryable<Move>> Get()
        {
            return Ok(_moveRepository.Get().AsNoTracking());
        }

        [HttpGet]
        [EnableQuery(MaxExpansionDepth = 2)]
        public ActionResult<Move> Get(int key)
        {
            return Ok(SingleResult.Create(_moveRepository.Get().Where(m => m.Id == key).AsNoTracking()));
        }
    }
}
