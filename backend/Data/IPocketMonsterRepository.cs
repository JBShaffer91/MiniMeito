using System.Collections.Generic;
using System.Threading.Tasks;
using MiniMeitoBackend.Models;

public interface IPocketMonsterRepository
{
  Task<IEnumerable<PocketMonster>> GetAllPocketMonstersAsync();
  Task<PocketMonster?> GetPocketMonsterByIdAsync(int id);
  Task AddPocketMonsterAsync(PocketMonster pocketMonster);
  Task UpdatePocketMonsterAsync(PocketMonster pocketMonster);
  Task DeletePocketMonsterAsync(int id);
}