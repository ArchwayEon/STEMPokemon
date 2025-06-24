using Microsoft.EntityFrameworkCore;
using STEMPokemon.Models;
using System;

namespace STEMPokemon.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Pokemon> Pokemon => Set<Pokemon>();

}
