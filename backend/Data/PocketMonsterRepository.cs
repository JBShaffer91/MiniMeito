using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MiniMeitoBackend.Models;

namespace MiniMeitoBackend.Data.Repositories
{
    public class PocketMonsterRepository : IPocketMonsterRepository
    {
        private readonly MiniMeitoDbContext _context;

        public PocketMonsterRepository(MiniMeitoDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<PocketMonster>> GetAllPocketMonstersAsync()
        {
            return await _context.PocketMonsters.ToListAsync();
        }

        public async Task<PocketMonster> GetPocketMonsterByIdAsync(int id)
        {
            return await _context.PocketMonsters.FindAsync(id);
        }

        public async Task AddPocketMonsterAsync(PocketMonster pocketMonster)
        {
            await _context.PocketMonsters.AddAsync(pocketMonster);
            await _context.SaveChangesAsync();
        }

        public async Task UpdatePocketMonsterAsync(PocketMonster pocketMonster)
        {
            _context.Entry(pocketMonster).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeletePocketMonsterAsync(int id)
        {
            var pocketMonster = await _context.PocketMonsters.FindAsync(id);
            _context.PocketMonsters.Remove(pocketMonster);
            await _context.SaveChangesAsync();
        }
    }
}
