using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Storage;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        //atributo -> DIP (Princípio de inversão de dependência)
        private readonly SqlContext context;

        //atributo -> armazenar as transações criadas
        private IDbContextTransaction transaction;

        public UnitOfWork(SqlContext context)
        {
            this.context = context;
        }

        public void BeginTransaction()
        {
            transaction = context.Database.BeginTransaction();
        }

        public void Commit()
        {
            transaction.Commit();
        }

        public void Rollback()
        {
            transaction.Rollback();
        }

        public IAlunoRepository AlunoRepository
            => new AlunoRepository(context);

        public IProfessorRepository ProfessorRepository
            => new ProfessorRepository(context);

        public ITurmaRepository TurmaRepository
            => new TurmaRepository(context);

        public ITurmaAlunoRepository TurmaAlunoRepository
            => new TurmaAlunoRepository(context);


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
