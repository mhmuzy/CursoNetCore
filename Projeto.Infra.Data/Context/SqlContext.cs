using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Projeto.Domain.Models;
using Projeto.Infra.Data.Mappings;

namespace Projeto.Infra.Data.Context
{
    //Regra 1) Herdar DbContext
    public class SqlContext : DbContext
    {
        //Regra 2) Construtor para receber as configurações para
        //acesso ao banco de dados do SqlServer
        public SqlContext(DbContextOptions<SqlContext> options) : base(options)
        {

        }

        //Regra 3) Declarar um DbSet (CRUD) para cada modelo de dados
        public DbSet<Aluno> Alunos { get; set; }

        //Regra 4) Sobrescrita (OVERRIDE) do método OnModelCreating
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //adicionar as classes de mapeamento
            modelBuilder.ApplyConfiguration(new AlunoMap());

            //adicionar índices na tabela
            modelBuilder.Entity<Aluno>(entity => {
                entity.HasIndex(a => a.Cpf).IsUnique();
                entity.HasIndex(a => a.Matricula).IsUnique();
            });

            base.OnModelCreating(modelBuilder);
        }
    }
}
