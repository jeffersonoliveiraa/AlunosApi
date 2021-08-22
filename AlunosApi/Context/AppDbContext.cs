using AlunosApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlunosApi.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Aluno> Alunos { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Aluno>().HasData(
                new Aluno
                {
                    Id = 1,
                    Nome = "Jefferson Oliveira Rodrigues",
                    Email = "jefferson.oliveira@gmail.com",
                    Idade = 23
                },
                new Aluno
                {
                    Id = 2,
                    Nome = "Rebeca Estevão Alexandre",
                    Email = "rebecaestevao@gmail.com",
                    Idade = 22
                }
            );

        }
    }
}

