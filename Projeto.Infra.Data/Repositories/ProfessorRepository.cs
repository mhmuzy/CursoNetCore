using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Interfaces.Repositories;
using Projeto.Domain.Models;
using Projeto.Infra.Data.Context;

namespace Projeto.Infra.Data.Repositories
{
    public class ProfessorRepository
        : BaseRepository<Professor>, IProfessorRepository
    {
        //injeção de dependência
        public ProfessorRepository(SqlContext context) : base(context)
        {

        }
    }
}
