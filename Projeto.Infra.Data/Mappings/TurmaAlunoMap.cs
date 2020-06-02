﻿using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Projeto.Domain.Models;

namespace Projeto.Infra.Data.Mappings
{
    public class TurmaAlunoMap : IEntityTypeConfiguration<TurmaAluno>
    {
        public void Configure(EntityTypeBuilder<TurmaAluno> builder)
        {
            //chave primária composta
            builder.HasKey(t => new { t.TurmaId, t.AlunoId });

            builder.HasOne(t => t.Turma)
                .WithMany(t => t.Alunos)
                .HasForeignKey(t => t.TurmaId);

            builder.HasOne(t => t.Aluno)
                .WithMany(t => t.Turmas)
                .HasForeignKey(t => t.AlunoId);
        }
    }
}
