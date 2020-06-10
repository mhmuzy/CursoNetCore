using Projeto.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Infra.Data.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        #region Escopo de transações

        void BeginTransaction();
        void Commit();
        void Rollback();

        #endregion

        #region Repositórios

        IAlunoRepository AlunoRepository { get; }
        IProfessorRepository ProfessorRepository { get; }
        ITurmaRepository TurmaRepository { get; }
        ITurmaAlunoRepository TurmaAlunoRepository { get; }

        #endregion
    }
}
