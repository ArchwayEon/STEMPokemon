namespace STEMPokemon.Models;

public class Pokemon
{
    public int Id { get; set; }
    public int Num { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Type1 { get; set; } = string.Empty;
    public string? Type2 { get; set; }
    public int HP { get; set; }
    public int Attack { get; set; }
    public int Defense { get; set; }
    public int SpAtk { get; set; }
    public int SpDef { get; set; }
    public int Speed { get; set; }
    public int Generation { get; set; }
    public bool Legendary { get; set; }
}
