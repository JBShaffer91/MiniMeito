using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MiniMeitoBackend.Data.Repositories;
using MiniMeitoBackend.Models;

namespace MiniMeitoBackend.Controllers
{
    [ApiController]
    [Route("api/pocketmonsters")]
    public class PocketMonsterController : ControllerBase
    {
        private readonly IPocketMonsterRepository _repository;

        public PocketMonsterController(IPocketMonsterRepository repository)
        {
            _repository = repository;
        }

        // GET: api/PocketMonster
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PocketMonster>>> GetPocketMonsters()
        {
            var pocketMonsters = await _repository.GetAllPocketMonstersAsync();
            return Ok(pocketMonsters);
        }

        // GET: api/PocketMonster/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PocketMonster>> GetPocketMonster(int id)
        {
            var pocketMonster = await _repository.GetPocketMonsterByIdAsync(id);

            if (pocketMonster == null)
            {
                return NotFound();
            }

            return Ok(pocketMonster);
        }

        // POST: api/PocketMonster
        [HttpPost]
        public async Task<ActionResult<PocketMonster>> PostPocketMonster(PocketMonster pocketMonster)
        {
            await _repository.AddPocketMonsterAsync(pocketMonster);
            return CreatedAtAction(nameof(GetPocketMonster), new { id = pocketMonster.Id }, pocketMonster);
        }

        // PUT: api/PocketMonster/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPocketMonster(int id, PocketMonster pocketMonster)
        {
            if (id != pocketMonster.Id)
            {
                return BadRequest();
            }

            await _repository.UpdatePocketMonsterAsync(pocketMonster);

            return NoContent();
        }

        // DELETE: api/PocketMonster/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePocketMonster(int id)
        {
            var pocketMonster = await _repository.GetPocketMonsterByIdAsync(id);
            if (pocketMonster == null)
            {
                return NotFound();
            }

            await _repository.DeletePocketMonsterAsync(id);

            return NoContent();
        }
    }
}
