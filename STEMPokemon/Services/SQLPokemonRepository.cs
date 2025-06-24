using Microsoft.EntityFrameworkCore;
using STEMPokemon.Models;

namespace STEMPokemon.Services;

public class SQLPokemonRepository
{
    private readonly ApplicationDbContext _db;

    public SQLPokemonRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public IEnumerable<Pokemon> GetAllPokemons()
    {
        return _db.Pokemon
            .FromSqlRaw("SELECT * FROM Pokemon");
    }

}
