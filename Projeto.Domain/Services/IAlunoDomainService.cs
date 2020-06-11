using System;
using System.Collections.Generic;
using System.Text;
using Projeto.Domain.Models;

namespace Projeto.Domain.Services
{
    public interface IAlunoDomainService : IBaseDomainService<Aluno>
    {
        Aluno GetByMatricula(string matricula);
        Aluno GetByCpf(string cpf);
    }
}
