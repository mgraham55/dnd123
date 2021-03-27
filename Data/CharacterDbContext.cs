﻿using dnd123.Models.Character;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dnd123.Data
{
    public class CharacterDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }

        public CharacterDbContext(DbContextOptions<CharacterDbContext> options) : base(options)
        {

        }
    }
}
