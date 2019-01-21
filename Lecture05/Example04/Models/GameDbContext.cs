using System;
using Microsoft.EntityFrameworkCore;

namespace Example04.Models
{
    // 資料庫的概念
    public class GameDbContext : DbContext
    {
        // 資料表 資料集
        public DbSet<Pokemon> Pokemons { get; set; }

        // Builder Pattern
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=game.db");
        }
    }
}