﻿using DevIO.UI.Site.Models;
using Microsoft.EntityFrameworkCore;

namespace DevIO.UI.Site.Data
{
    public class MeuDbContext : DbContext
    {
        public MeuDbContext(DbContextOptions options)
        : base(options)
        {

        }

        public DbSet<Aluno> Alunos { get; set; }
    }
}