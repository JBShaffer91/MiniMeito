using System;

namespace MiniMeitoBackend.Models
{
  public class PocketMonster
  {
    public int Id { get; set; }
    public string? Name { get; set; }
    public int Food { get; set; }
    public int Attention { get; set; }
    public int Rest { get; set; }
    public int Happiness { get; set; }
    public int Age { get; set; }
    public bool IsDead { get; set; }
  }
}
