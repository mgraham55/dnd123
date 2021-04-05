using dnd123.Models.Character;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.Data
{
    public class CharacterDbContext : IdentityDbContext
    {
        public DbSet<Character> Characters { get; set; }

        public DbSet<CharacterAbility> CharacterAbility { get; set; }

        public CharacterDbContext(DbContextOptions<CharacterDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CharacterAbility>()
                .HasKey(j => new { j.CharacterId, j.AbilityId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
