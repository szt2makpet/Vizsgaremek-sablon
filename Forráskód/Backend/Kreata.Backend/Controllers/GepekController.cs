using Kreata.Backend.Datas.Entities;
using Kreata.Backend.Repos;
using Microsoft.AspNetCore.Mvc;

namespace Kreata.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GepekController : ControllerBase
    {
        private IGepRepo _gepRepo;

        public GepekController(IGepRepo gepRepo)
        {
            _gepRepo = gepRepo;
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBy(Guid id)
        {
            GepAdatok? entity = new();
            if (_gepRepo is not null)
            {
                entity = await _gepRepo.GetBy(id);
                if (entity!=null) 
                    return Ok(entity);
            }
            return BadRequest("Az adatok elérhetetlenek!");
        }

        [HttpGet]
        public async Task<IActionResult> SelectAllRecordToListAsync()
        {
            List<GepAdatok>? gep = new();

            if (_gepRepo != null)
            {
                gep = await _gepRepo.GetAll();
                return Ok(gep);
            }
            return BadRequest("Az adatok elérhetetlenek.");
        }
    }
}
